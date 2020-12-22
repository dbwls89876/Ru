package exception;

public class PasswordExceptionTest {
	private String password;
	
	public void setPassword(String password) throws PasswordException{
		if(password == null) {
			throw new PasswordException("비밀번호는 null일 수 없습니다.");
		}
		else if(password.matches("[a-zA-Z]+")) {
			throw new PasswordException("비밀번호는 문자열로만 이루어질 수 없습니다.");
		}
		else if(password.length()<=5) {
			throw new PasswordException("비밀번호는 6자이상이어야 합니다.");
		}
		this.password = password;
	}
	public static void main(String[] args) {
		PasswordExceptionTest test = new PasswordExceptionTest();
		
		String pass1 = null;
		String pass2 = "aaa";
		String pass3 = "aaa1";
		
		try{
			test.setPassword(pass1);
			
		}catch(PasswordException e) {
			System.out.println(e.getMessage());
		}
		
		try{
			test.setPassword(pass2);
			
		}catch(PasswordException e) {
			System.out.println(e.getMessage());
		}
		try{
			test.setPassword(pass3);
			
		}catch(PasswordException e) {
			System.out.println(e.getMessage());
		}
	}

}
