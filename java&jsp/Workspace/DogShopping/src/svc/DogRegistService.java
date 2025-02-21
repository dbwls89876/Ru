package svc;

import static db.JdbcUtil.*;
import java.sql.Connection;

import dao.DogDAO;
import vo.Dog;

public class DogRegistService {
	public boolean registDog(Dog dog) {
		Connection con = null;
		boolean isRegistSuccess = false;
		
		try {
			DogDAO dogDAO = DogDAO.getInstance();
			con = getConnection();
			dogDAO.setConnection(con);
			
			int insertCount = dogDAO.insertDog(dog);
			if(insertCount>0) {
			commit(con);
			isRegistSuccess = true;
			}else {
				rollback(con);
			}
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(con);
		}
		return isRegistSuccess;
		
	}
}
