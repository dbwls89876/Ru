package ������;

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
		System.out.println("*�⺻����* ���� : " + kor + ", ���� : " + eng + ", ���� : " + math
			+ " | [�հ� : " + sum + ", ��� : " + avg + " ]");
		
	}
}
