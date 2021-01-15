package 평가2.정유진.subject;

public class ScienceSubject extends Subject{
	private int phy;
	private int chemi;
	public ScienceSubject(int kor, int eng, int math, int phy, int chemi) {
		super(kor, eng, math);
		// TODO Auto-generated constructor stub	
		this.phy = phy;
		this.chemi = chemi;
		sum();
		average();
	}
	public int getPhy() {
		return phy;
	}
	public void setPhy(int phy) {
		this.phy = phy;
	}
	public int getChemi() {
		return chemi;
	}
	public void setChemi(int chemi) {
		this.chemi = chemi;
	}
	@Override
	public void sum() {
		sum = kor + eng + math + phy + chemi;
	}
	@Override
	public void average() {
		avg = (kor+eng+math+phy+chemi)/5.0;
	}
	@Override
	public void showSubjectInfo() {
		System.out.println("*기본교과* 국어 : " + kor + ", 영어 : " + eng + ", 수학 : " + math
				+ " | *이과 교과* 물리 : " + phy + ", 화학 : " + chemi
				+ " | [합계 : " + sum + ", 평균 : " + String.format("%.0f", avg) + ".0 ]");
	}
	
}
