package mailtest;

import javax.mail.Authenticator;
import javax.mail.PasswordAuthentication;

public class GoogleAuthentication extends Authenticator {
	PasswordAuthentication passAuth;
	
	public GoogleAuthentication() {
		passAuth = new PasswordAuthentication("dbwls89876@gmail.com", "ckhrddrstctophzk");
	}
	
	public PasswordAuthentication getPasswordAuthentication() {
		return passAuth;
	}
}
