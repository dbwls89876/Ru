package chapter4;

public class IfExample2_1 {
	public static void main(String[] args) {
int age = 0, charge = 0;
		
		if(age<8) {
			charge = 1000;
			System.out.println("���� �� �Ƶ��Դϴ�.");
		}
		if(age>=8&&age<14) {
			charge = 2000;
			System.out.println("�ʵ��л��Դϴ�.");
		}
		if(age>=14&&age<20) {
			charge = 2500;
			System.out.println("��, ����л��Դϴ�.");
		}
		if(age>=20&&age<60){
			charge = 3000;
			System.out.println("�Ϲ����Դϴ�.");
		}
		
		System.out.println("������" + charge + "���Դϴ�.");
	}
}
