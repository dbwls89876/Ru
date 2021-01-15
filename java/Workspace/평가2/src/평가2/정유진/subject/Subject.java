package 평가2.정유진.subject;

public class Subject {
	protected int kor, eng, math, sum;
	protected double avg;
	
	public Subject(int kor, int eng, int math) {
		this.kor = kor;
		this.eng = eng;
		this.math = math;
		sum();
		average();
	}
	
	public void sum() {
		sum = kor + eng + math;
	}
	
	public void average() {
		avg = (kor+eng+math)/3.0;
	}
	
	public void showSubjectInfo(){
		System.out.println("*기본교과* 국어 : " + kor + ", 영어 : " + eng + ", 수학 : " + math
			+ " | [합계 : " + sum + ", 평균 : " + String.format("%.0f", avg) + ".0 ]");
		
	}

	public int getKor() {
		return kor;
	}

	public void setKor(int kor) {
		this.kor = kor;
	}

	public int getEng() {
		return eng;
	}

	public void setEng(int eng) {
		this.eng = eng;
	}

	public int getMath() {
		return math;
	}

	public void setMath(int math) {
		this.math = math;
	}

	public int getSum() {
		return sum;
	}

	public void setSum(int sum) {
		this.sum = sum;
	}

	public double getAvg() {
		return avg;
	}

	public void setAvg(double avg) {
		this.avg = avg;
	}
}
