package yn.grade;

public class MemberGrade {
	protected String grade;
	protected int bonusPoint;
	protected double bonusRate;
	protected double saleRate;
	
	public MemberGrade(){
		grade = "Bronze";
		bonusPoint = 1000;
		bonusRate = 0.01;
		saleRate = 0; 
	}
	
	public int calcPrice(int price){
		bonusPoint = bonusPoint + (int)(price*bonusRate);
		return (int)(price-(price*saleRate));
	}
	
	public String showGradeInfo(){
		return "회원 등급 : " + grade + ", 보너스 포인트 : " + bonusPoint; 
	}
}
  