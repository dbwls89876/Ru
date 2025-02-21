package controller;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import action.Action;
import board.action.*;
import vo.ActionForward;

/**
 * Servlet implementation class BoardFrontController
 */
@WebServlet("*.bo")
public class BoardFrontController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public BoardFrontController() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doProcess(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doProcess(request, response);
	}

	private void doProcess(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("utf-8");
		String RequestURI = request.getRequestURI();
		String contextPath = request.getContextPath();
		String command = RequestURI.substring(contextPath.length());
		ActionForward forward=null;
		Action action=null;
		System.out.println(command);
		if(command.equals("/boardWriteForm.bo")) {
			try {
				forward = new ActionForward();
				forward.setPath("/board/qna_board_write.jsp");
			}catch(Exception e) {
				e.printStackTrace();
			}
		}
		else if(command.equals("/boardWritePro.bo")) {
			action = new BoardWriteProAction();
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}else if(command.equals("/boardList.bo")) {
			action = new BoardListAction();
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}else if(command.equals("/boardDetail.bo")) {
			action = new BoardDtailAction();
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}else if(command.equals("/boardModifyForm.bo")) {
			action = new BoardModifyFormAction();
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
			
		}else if(command.equals("/boardReplayForm.bo")){
			action = new BoardReplayFormAction();
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}else if(command.equals("/boardDeleteForm.bo")) {
			String nowPage = request.getParameter("page");
			request.setAttribute("page", nowPage);
			int board_num = Integer.parseInt(request.getParameter("board_num"));
			request.setAttribute("board_num", board_num);
			try {
				forward = action.execute(request, response);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}
		if(forward!=null) {
			if(forward.isRedirect()) {
				response.sendRedirect(forward.getPath());
			}else {
				RequestDispatcher dispatcher = request.getRequestDispatcher(forward.getPath());
				dispatcher.forward(request, response);
			}
		}
	}

}
