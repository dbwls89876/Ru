package 평가2.정유진.subject;

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
		System.out.println("*기본교과* 국어 : " + kor + ", 영어 : " + eng + ", 수학 : " + math
				+" | *문과 교과* 역사 : " + his
				+ " | [합계 : " + sum + ", 평균 : " + String.format("%.0f", avg) + ".0 ]");
	}
	
}
