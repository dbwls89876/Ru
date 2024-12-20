package dao;

import static db.JdbcUtil.*;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import javax.sql.DataSource;

import vo.Member;

public class LoginDAO {
	DataSource ds;
	Connection con;
	private static LoginDAO loginDAO;
	private LoginDAO() {}
	
	public static LoginDAO getInstance() {
		if(loginDAO == null) {
			loginDAO = new LoginDAO();
		}
		return loginDAO;
	}
	
	public void setConnection(Connection con) {
		this.con = con;
	}
	
	public Member selectLoginMember(String id, String password) {
		Member loginMember = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		String sql = "select * from users where id = ? and password = ?";
		try {
			pstmt = con.prepareStatement(sql);
			pstmt.setString(1, id);
			pstmt.setString(2, password);
			rs = pstmt.executeQuery();
			if(rs.next()) {
				loginMember = new Member();
				loginMember.setId(rs.getString("id"));
				loginMember.setPassword(rs.getString("password"));
				loginMember.setAge(rs.getInt("age"));
				loginMember.setGender(rs.getString("gender"));
				loginMember.setEmail(rs.getString("email"));
				loginMember.setNation(rs.getString("nation"));
				loginMember.setGrade(rs.getString("grade"));
				loginMember.setAddr(rs.getString("addr"));
			}
			
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(pstmt);
			close(rs);
		}
		return loginMember;
	}
}
