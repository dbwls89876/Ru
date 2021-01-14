package 정유진;

public class Subject {
	protected int kor, eng, math, sum;
	protected double avg;
	
	public Subject() {
		
	}
	
	public void sum() {
		sum = kor + eng + math;
	}
	
	public void average() {
		avg = kor*eng*math/3.0;
	}
	
	public void showSubjectInfo(){
		System.out.println("*기본교과* 국어 : " + kor + ", 영어 : " + eng + ", 수학 : " + math
			+ " | [합계 : " + sum + ", 평균 : " + avg + " ]");
		
	}
}
