

import java.io.IOException;
import java.io.PrintWriter;
import java.lang.ProcessBuilder.Redirect;
import java.util.Enumeration;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.oreilly.servlet.MultipartRequest;
import com.oreilly.servlet.multipart.DefaultFileRenamePolicy;

/**
 * Servlet implementation class FileUploadServlet
 */
@WebServlet("/fileUpload")
public class FileUploadServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FileUploadServlet() {
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
		String uploadPath=request.getServletContext().getRealPath("/upload");
		response.setContentType("text/html;charset=UTF-8");
		int size = 10*1024*1024;
		String name="";
		String subject="";
		String filename1="";
		String filename2="";
		String origfilename1="";
		String origfilename2="";
		PrintWriter out = response.getWriter();
		
		try{
			MultipartRequest multi = new MultipartRequest(request, uploadPath, size, "UTF-8", new DefaultFileRenamePolicy());
			
			name=multi.getParameter("name");
			subject = multi.getParameter("subject");
			
			Enumeration files=multi.getFileNames();
			
			String file1 = (String)files.nextElement();
			filename1=multi.getFilesystemName(file1);
			origfilename1=multi.getOriginalFileName(file1);
			
			String file2=(String)files.nextElement();
			filename2 = multi.getFilesystemName(file2);
			origfilename2 = multi.getOriginalFileName(file2);
		}catch(Exception e){
			e.printStackTrace();
		}
		
		request.setAttribute("name", name);
		request.setAttribute("subject", subject);
		request.setAttribute("filename1", filename1);
		request.setAttribute("filename2", filename2);
		request.setAttribute("origfilename1", origfilename1);
		request.setAttribute("origfilename2", origfilename2);
		
		RequestDispatcher dispatcher = request.getRequestDispatcher("fileUploadServlet.jsp");
		dispatcher.forward(request, response);
		/*
		 * out.println("<html>"); out.println("<head>"); out.println("</head>");
		 * out.println("<body>"); out.
		 * println("<form name=\"filecheck\" action=\"fileCheck.jsp\" method=\"post\">"
		 * ); out.println("<input type=\"hidden\" name=\"name\" value="+name+">");
		 * out.println("<input type=\"hidden\" name=\"subject\" value="+subject+">");
		 * out.println("<input type=\"hidden\" name=\"filename1\" value="+filename1+">")
		 * ;
		 * out.println("<input type=\"hidden\" name=\"filename2\" value="+filename2+">")
		 * ; out.println("<input type=\"hidden\" name=\"origfilename1\" value="
		 * +origfilename1+">");
		 * out.println("<input type=\"hidden\" name=\"origfilename2\" value="
		 * +origfilename2+">");
		 * 
		 * out.println("</form>"); out.
		 * println("<a href=\"#\" onclick=\"javascript:filecheck.submit()\">업로드 확인 및 다운로드 페이지 이동</a>"
		 * ); out.println("</doby>");
		 * 
		 * out.println("</html>");
		 */

	}

}
