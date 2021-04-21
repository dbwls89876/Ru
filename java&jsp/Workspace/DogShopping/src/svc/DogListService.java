package svc;

import static db.JdbcUtil.*;
import java.sql.Connection;
import java.util.ArrayList;

import dao.DogDAO;
import vo.Dog;

public class DogListService {

	public ArrayList<Dog> getDogList() {
		// TODO Auto-generated method stub
		Connection con = null;
		ArrayList<Dog> dogList = null;
		try {
			DogDAO dogDAO = DogDAO.getInstance();
			con = getConnection();
			dogDAO.setConnection(con);
			dogList = dogDAO.selectDogList();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(con);
		}
		return dogList;
	}
	
}
