

import java.awt.Graphics2D;
import java.awt.image.BufferedImage;
import java.awt.image.renderable.ParameterBlock;
import java.io.File;
import java.io.IOException;
import java.net.URLEncoder;
import java.util.Enumeration;

import javax.imageio.ImageIO;
import javax.media.jai.JAI;
import javax.media.jai.RenderedOp;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.oreilly.servlet.MultipartRequest;
import com.oreilly.servlet.multipart.DefaultFileRenamePolicy;

/**
 * Servlet implementation class ThumbnailServlet
 */
@WebServlet("/thumbnail")
public class ThumbnailServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ThumbnailServlet() {
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
		ServletContext context = request.getServletContext();
		String imagePath=context.getRealPath("image");
		int size = 1*1024*1024;
		String filename="";
		response.setContentType("text/html;charset=UTF-8");
		
		try{
			MultipartRequest multi = new MultipartRequest(request, imagePath, size, "euc-kr", new DefaultFileRenamePolicy());
			Enumeration files = multi.getFileNames();
			String file = (String)files.nextElement();
			filename=multi.getFilesystemName(file);
		}catch(Exception e){
			e.printStackTrace();
		}
		
		ParameterBlock pb = new ParameterBlock();
		pb.add(imagePath+"/"+filename);
		RenderedOp rOp = JAI.create("fileload", pb);
		
		BufferedImage bi = rOp.getAsBufferedImage();
		BufferedImage thumb = new BufferedImage(100, 100, BufferedImage.TYPE_INT_RGB);
		Graphics2D g = thumb.createGraphics();
		g.drawImage(bi, 0, 0, 100, 100, null);
		File file = new File(imagePath + "/sm_" + filename);
		ImageIO.write(thumb, "jpg", file);
		
		request.setAttribute("filename", filename);
		
		RequestDispatcher dispatcher = request.getRequestDispatcher("thumbnailView.jsp");
		dispatcher.forward(request, response);
//		response.sendRedirect("thumbnamilView.jsp?filename="+URLEncoder.encode(filename, "utf-8"));
	}

}
