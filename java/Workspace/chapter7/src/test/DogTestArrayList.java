package test;

import java.util.ArrayList;

public class DogTestArrayList {
	static ArrayList<Dog> list = new ArrayList<Dog>();
	public static void main(String[] args) {
		DogTestArrayList arr =  new DogTestArrayList();
		Dog[] d = new Dog[5];
		String[] doName = {"ÇØÇÇ","ÂĞ","¸Û","¸Ò","¹Ö"};
		String[] doType = {"Áø", "Áø", "Áø", "Áø", "Áø"};
		for(int i = 0; i<d.length; i++) {
			d[i] = new Dog(doName[i], doType[i]);
			arr.list.add(d[i]);
		}
		for(Dog dog : arr.list)
			System.out.println(dog.showDogInfo());
	}

}
