package yn;

import java.util.ArrayList;
import java.util.Date;

import yn.grade.MemberGrade;

public class Member {
	private String memberID;
	private String memberName;
	private String passwd;
	private MemberGrade memberGrade;
	private Date joinDate;
	public int rank;
	
	Member(String id, String name, String pw){
		this.memberID = id;
		this.memberName = name;
		this.passwd = pw;
		joinDate = new Date(System.currentTimeMillis());
		memberGrade = new MemberGrade();
		int rank = 0;
	}

	public String getMemberID() {
		return memberID;
	}

	public void setMemberID(String memberID) {
		this.memberID = memberID;
	}

	public String getMemberName() {
		return memberName;
	}

	public void setMemberName(String memberName) {
		this.memberName = memberName;
	}

	public String getPasswd() {
		return passwd;
	}

	public void setPasswd(String passwd) {
		this.passwd = passwd;
	}

	public MemberGrade getMemberGrade() {
		return memberGrade;
	}

	public void setMemberGrade(MemberGrade memberGrade) {
		this.memberGrade = memberGrade;
	}

	public Date getJoinDate() {
		return joinDate;
	}

	public void setJoinDate(Date joinDate) {
		this.joinDate = joinDate;
	}
	
	public void showInfo() {
		System.out.println("이름 : " + memberName);
		System.out.println("ID : " + memberID);
		System.out.println("가입일 : " + joinDate);
		System.out.println(memberGrade.showGradeInfo());
		System.out.println("순위 : " + (rank+1));
	}
	

	
}
