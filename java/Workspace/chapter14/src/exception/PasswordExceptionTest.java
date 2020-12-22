package exception;

public class PasswordExceptionTest {
	private String password;
	
	public void setPassword(String password) throws PasswordException{
		if(password == null) {
			throw new PasswordException("��й�ȣ�� null�� �� �����ϴ�.");
		}
		else if(password.matches("[a-zA-Z]+")) {
			throw new PasswordException("��й�ȣ�� ���ڿ��θ� �̷���� �� �����ϴ�.");
		}
		else if(password.length()<=5) {
			throw new PasswordException("��й�ȣ�� 6���̻��̾�� �մϴ�.");
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
