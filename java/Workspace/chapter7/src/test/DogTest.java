package test;

public class DogTest {

	public static void main(String[] args) {
		Dog[] d = new Dog[5];
		String[] doName = {"����","��","��","��","��"};
		
		
		d[0] = new Dog("��1", "������1");
		d[1] = new Dog("��2", "������2");
		d[2] = new Dog("��3", "������3");
		d[3] = new Dog("��4", "������4");
		d[4] = new Dog("��5", "������5");
		
		for(int i = 0; i<d.length; i++)
			d[i].setName(doName[i]);
		for(Dog dog : d)
			System.out.println(dog.showDogInfo());
		
	}
}
