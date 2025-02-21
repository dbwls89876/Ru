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
 * Servlet implementation class PartUploadPro1Servlet
 */
@WebServlet("/partUploadPro1")
@MultipartConfig(fileSizeThreshold = 0, location = "C:/jsp/upload")
public class PartUploadPro1Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public PartUploadPro1Servlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		response.setContentType("text/html; charset=UTF-8");
		String writer = request.getParameter("writer");
		PrintWriter out = response.getWriter();
		Part part = request.getPart("partFile1");
		
		
		String contentDisponsition = part.getHeader("content-disposition");
		String browser = getBrowser(request);
		String uploadFileName = getUploadFileName(browser, contentDisponsition);
		part.write(uploadFileName);
		out.println("작성자 " + writer + "님이" + uploadFileName + " 파일을 업로드 하였습니다.");
	}
	
	private String getUploadFileName(String browser, String contentDisopsition) {
		String uploadFileName = null;
		String[] contentSplitStr = contentDisopsition.split(";");
		int lastPathSeparatorIndex = contentSplitStr[2].lastIndexOf("\\");
		/*
		 * if(browser.trim()=="MSIE") { lastPathSeparatorIndex =
		 * contentSplitStr[2].lastIndexOf("\\"); }else { lastPathSeparatorIndex =
		 * contentSplitStr[2].lastIndexOf("\""); }
		 */
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
