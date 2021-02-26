package controller;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import svc.LoginService;
import vo.Member;

/**
 * Servlet implementation class LoginServlet
 */
@WebServlet("/login")
public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public LoginServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//쿠키
		Cookie[] cookie =  request.getCookies();
		String id = "";
		String password = "";
		if(cookie != null) {
			for(int i = 0; i<cookie.length; i++) {
				if(cookie[i].getName().equals("id")) {
					id = cookie[i].getValue();
				}
				else if(cookie[i].getName().equals("password")) {
					password = cookie[i].getValue();
				}
			}
			LoginService loginService = new LoginService();
			Member member = loginService.getLoginMember(id, password);
			
			if(loginService != null) {
				RequestDispatcher dispatcher = request.getRequestDispatcher("loginSuccess.jsp");
				request.setAttribute("member", member);
				dispatcher.forward(request, response);
			}else {
				RequestDispatcher dispatcher = request.getRequestDispatcher("lgoinForm.jsp");
				dispatcher.forward(request, response);
			}
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String id = request.getParameter("id"); 
		String password = request.getParameter("password"); 
		String useCookie = request.getParameter("useCookie");
		LoginService loginService = new LoginService();
		Member member = loginService.getLoginMember(id, password);
		
		if(useCookie != null) {
			Cookie idCookie = new Cookie("id", id);
			idCookie.setMaxAge(60*60*24);
			Cookie passwordCookie = new Cookie("password", password);
			passwordCookie.setMaxAge(60*60*24);
			response.addCookie(idCookie);
			response.addCookie(passwordCookie);
		}
		
		if(member != null) {
			RequestDispatcher dispatcher = request.getRequestDispatcher("loginSuccess.jsp");
			request.setAttribute("member", member);
			dispatcher.forward(request, response);
		}else {
			RequestDispatcher dispatcher = request.getRequestDispatcher("loginFail.jsp");
			dispatcher.forward(request, response);
		}
		/*
		 * String id = request.getParameter("id"); String password =
		 * request.getParameter("password"); LoginService loginService = new
		 * LoginService(); Member loginMember = loginService.getLoginMember(id,
		 * password);
		 * 
		 * //로그인 세션 if(loginMember != null) { HttpSession session =
		 * request.getSession(); session.setAttribute("id", id);
		 * response.sendRedirect("index.jsp"); }else {
		 * response.setContentType("text/html; charset=utf-8"); PrintWriter out =
		 * response.getWriter(); out.println("<script>");
		 * out.println("alert('로그인실패');"); out.println("history.back();");
		 * out.println("</script>"); }
		 */
	}

}
