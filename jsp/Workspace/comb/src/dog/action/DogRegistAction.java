package dog.action;

import java.io.PrintWriter;

import javax.servlet.ServletContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.oreilly.servlet.MultipartRequest;
import com.oreilly.servlet.multipart.DefaultFileRenamePolicy;

import action.Action;
import dog.svc.DogRegistService;
import vo.ActionForward;
import vo.Dog;

public class DogRegistAction implements Action {

	@Override
	public ActionForward execute(HttpServletRequest request, HttpServletResponse response) throws Exception {
		// TODO Auto-generated method stub
		DogRegistService dogRegistService = new DogRegistService();
		String realFolder = ""; // 서버 상의 물리 경로
		
		String saveFolder = "/images";
		String encType="UTF-8";
		int maxSize = 5*1024*1024;// 한번에 업로드 할 수 있는 파일 크기
		
		
		ServletContext context = request.getServletContext();
		realFolder = context.getRealPath(saveFolder);
		MultipartRequest multi = 
				new MultipartRequest(request, realFolder, maxSize, encType, new DefaultFileRenamePolicy());
		String image = multi.getFilesystemName("image");
		Dog dog = new Dog(0, multi.getParameter("kind"), Integer.parseInt(multi.getParameter("price")),
				image, multi.getParameter("nation"), Integer.parseInt(multi.getParameter("height")),
				Integer.parseInt(multi.getParameter("weight")), multi.getParameter("content"), 0);
		boolean isRegistSuccess = dogRegistService.registDog(dog);
		ActionForward forward = null;
		
		if(isRegistSuccess) {
			forward = new ActionForward("dogList.dog", true);
		}else {
			response.setContentType("text/html;charset=utf-8");
			PrintWriter out = response.getWriter();
			out.println("<script>");
			out.println("alert('등록 실패');");
			out.println("history.back();");
			out.println("</script>");
		}

		
		return forward;
	}

}
