package svc;

import java.sql.Connection;

import dao.BoardDAO;
import vo.BoardBean;
import static db.JdbcUtil.*;

public class BoardWriteProService {
	public boolean registArticle(BoardBean boardBean) {
		boolean isWriteSuccess = false;
		Connection con = getConnection();
		try {
			
			BoardDAO boardDAO = BoardDAO.getInstance();
			boardDAO.setConnection(con);
			int insertCount = boardDAO.insertArticle(boardBean);
			
			if(insertCount>0) {
				commit(con);
				isWriteSuccess = true;
			}
			else {
				rollback(con);
			}
		}catch(Exception e) {
			e.printStackTrace();
		}finally {
			close(con);
		}
		
		
		return isWriteSuccess;
	}
}
