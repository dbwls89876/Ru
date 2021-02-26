import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.Part;

/**
 * Servlet implementation class PartUploadPro2Servlet
 */
@WebServlet("/partUploadPro2")
@MultipartConfig(fileSizeThreshold = 0, location = "C:/jsp/upload")
public class PartUploadPro2Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public PartUploadPro2Servlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		String writer = request.getParameter("writer");
		String uploadFileNameList = "";
		for(Part part: request.getParts()) {
			if(!part.getName().equals("writer")) {
				String contentDisponsition = part.getHeader("content-disposition");
				String uploadFileName = getUploadFileName(getBrowser(request), contentDisponsition);
				part.write(uploadFileName);
				uploadFileNameList += " " + uploadFileName;
			}
		}
		
		out.println("작성자 " + writer + "님이" + uploadFileNameList + " 파일을 업로드 하였습니다.");
	}

	private String getUploadFileName(String browser, String contentDisponsition) {
		String uploadFileName = null;
		String[] contentSplitStr = contentDisponsition.split(";");
		int lastPathSeparatorIndex;
		/*
		 * if(browser.trim()=="MSIE") { 
		 * lastPathSeparatorIndex =contentSplitStr[2].lastIndexOf("\\"); }
		 * else { lastPathSeparatorIndex =
		 * contentSplitStr[2].lastIndexOf("\""); }
		 */
		lastPathSeparatorIndex = contentSplitStr[2].lastIndexOf("\"");
		int lastQutosIndex = contentSplitStr[2].lastIndexOf("\"");
		uploadFileName = contentSplitStr[2].substring(lastPathSeparatorIndex + 1, lastQutosIndex);
		return uploadFileName;
	}
	
	private String getBrowser(HttpServletRequest request) {
		String header = request.getHeader("User-Agent");
		if(header != null) {
			if(header.indexOf("trident")>-1) {
				return "MSIE";
			}else if(header.indexOf("Chrome")>-1) {
				return "Chrome";
			}else if(header.indexOf("Opera")>-1) {
				return "Opera";
			}
		}
		return "Firefox";
		
	}

}
