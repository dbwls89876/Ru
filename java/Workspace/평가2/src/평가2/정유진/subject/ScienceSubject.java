package ��2.������.subject;

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
		System.out.println("*�⺻����* ���� : " + kor + ", ���� : " + eng + ", ���� : " + math
				+ " | *�̰� ����* ���� : " + phy + ", ȭ�� : " + chemi
				+ " | [�հ� : " + sum + ", ��� : " + String.format("%.0f", avg) + ".0 ]");
	}
	
}
