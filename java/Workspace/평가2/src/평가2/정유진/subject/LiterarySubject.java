package ��2.������.subject;

public class LiterarySubject extends Subject{
	private int his;
	
	public LiterarySubject(int kor, int eng, int math, int his) {
		super(kor, eng, math);
		// TODO Auto-generated constructor stub
		this.his = his;
		sum();
		average();
	}
	
	public int getHis() {
		return his;
	}
	public void setHis(int his) {
		this.his = his;
	}

	@Override
	public void sum() {
		sum = kor + eng + math + his;
	}

	@Override
	public void average() {
		avg = (kor+eng+math+his)/4.0;
	}

	@Override
	public void showSubjectInfo() {
		System.out.println("*�⺻����* ���� : " + kor + ", ���� : " + eng + ", ���� : " + math
				+" | *���� ����* ���� : " + his
				+ " | [�հ� : " + sum + ", ��� : " + String.format("%.0f", avg) + ".0 ]");
	}
	
}
