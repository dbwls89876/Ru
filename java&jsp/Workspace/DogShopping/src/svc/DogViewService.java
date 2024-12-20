package svc;

import static db.JdbcUtil.*;
import java.sql.Connection;

import dao.DogDAO;
import vo.Dog;

public class DogViewService {

	public Dog getDogView(int id) {
		// TODO Auto-generated method stub
		Connection con = null;
		Dog dog = null;
		try {
			con = getConnection();
			DogDAO dogDAO = DogDAO.getInstance();
			dogDAO.setConnection(con);
			int updateCount = dogDAO.updateReadCount(id);
			if(updateCount > 0) {
				commit(con);
			}else {
				rollback(con);
			}
			dog = dogDAO.selectDog(id);
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(con);
		}
		
		return dog;
	}

}
