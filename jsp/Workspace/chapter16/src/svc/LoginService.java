package svc;

import static db.JdbcUtil.*;
import java.sql.Connection;

import dao.LoginDAO;
import vo.Member;

public class LoginService {

	public Member getLoginMember(String id, String password) {
		LoginDAO loginDAO = LoginDAO.getInstance();
		Connection con = null;
		Member loginMember = null;
		try {
			 con = getConnection();
			 loginDAO.setConnection(con);
			 loginMember = loginDAO.selectLoginMember(id, password);
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(con);
		}
		return loginMember;
	}
	
}
