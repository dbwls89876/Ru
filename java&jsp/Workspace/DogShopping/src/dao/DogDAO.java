package dao;

import static db.JdbcUtil.close;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import javax.sql.DataSource;

import vo.Dog;

public class DogDAO {
	DataSource ds;
	Connection con;
	private static DogDAO dogDAO;
	private DogDAO() {}
	
	public static DogDAO getInstance() {
		if(dogDAO == null) {
			dogDAO = new DogDAO();
		}
		return dogDAO;
	}
	
	public void setConnection(Connection con) {
		this.con = con;
	}
	
	public int insertDog(Dog dog) {
		PreparedStatement pstmt = null;
		String sql = "";
		int insertCount=0;
		
		try {
			sql="insert into dog values(dog_seq.nextval, ?,?,?,?,?,?,?,?)";
			pstmt = con.prepareStatement(sql);
			pstmt.setString(1, dog.getKind());
			pstmt.setInt(2, dog.getPrice());
			pstmt.setString(3, dog.getImage());
			pstmt.setString(4, dog.getCountry());
			pstmt.setInt(5, dog.getHeight());
			pstmt.setInt(6, dog.getWeight());
			pstmt.setString(7, dog.getContent());
			pstmt.setInt(8, dog.getReadCount());
			insertCount = pstmt.executeUpdate();
		}catch(Exception e) {
			e.printStackTrace();
		}finally {
			close(pstmt);
		}
		
		return insertCount;
	}

	public ArrayList<Dog> selectDogList() {
		// TODO Auto-generated method stub
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		ArrayList<Dog>dogList = null;
		String sql = "select * from dog";
		try {
			pstmt = con.prepareStatement(sql);
			rs = pstmt.executeQuery();
			dogList = new ArrayList<Dog>();
			if(rs.next()) {
				do {
					dogList.add(new Dog(
							rs.getInt("id")
							,rs.getString("kind")
							,rs.getInt("price")
							,rs.getString("image")
							,rs.getString("country")
							,rs.getInt("height")
							,rs.getInt("weight")
							,rs.getString("content")
							,rs.getInt("readCount")
							));
					//데이터 확인 지우기
				}while(rs.next());
			}
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(pstmt);
			close(rs);
		}
		return dogList;
	}

	public Dog selectDog(int id) {
		// TODO Auto-generated method stub
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		Dog dog = null;
		String sql = "select * from dog where id=?";
		try {
			pstmt = con.prepareStatement(sql);
			pstmt.setInt(1, id);
			rs = pstmt.executeQuery();
			
			if(rs.next()) {
				dog = new Dog(
						rs.getInt("id")
						,rs.getString("kind")
						,rs.getInt("price")
						,rs.getString("image")
						,rs.getString("country")
						,rs.getInt("height")
						,rs.getInt("weight")
						,rs.getString("content")
						,rs.getInt("readCount")
						);
						
			}
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(pstmt);
			close(rs);
		}
		return dog;
	}

	public int updateReadCount(int id) {
		PreparedStatement pstmt = null;
		int updateCount = 0;
		String sql = "";
		
		try {
			sql = "update dog set readCount = readCount + 1 where id=?";
			pstmt = con.prepareStatement(sql);
			pstmt.setInt(1, id);
			updateCount = pstmt.executeUpdate();
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}finally {
			close(pstmt);
		}
		
		return updateCount;
	}
	
}
