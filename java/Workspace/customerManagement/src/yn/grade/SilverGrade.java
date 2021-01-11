package yn.grade;

public class SilverGrade extends MemberGrade{
	public SilverGrade(){
		grade = "Silver";
		bonusRate = 0.02;
		saleRate = 0.03;
	}
	
	public SilverGrade(int bonusPoint) {
		this();
		this.bonusPoint = bonusPoint;
	}
	
	@Override
	public String showGradeInfo() {
		return super.showGradeInfo() + " *실버 고객 정보*"; 
	}
}
