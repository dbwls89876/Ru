package test;

public class Chapter7Q2 {
	
	public static void main(String[] args) {
		char[] alphabets = new char[26];
		char ch = 'a';
		
		for(int i = 0; i < alphabets.length; i++, ch++) {
			alphabets[i] = ch;
		}
		
		for(int i = 0; i<alphabets.length; i++)
			System.out.println((char)(alphabets[i]-32) );//�ƴ� �Ʊ�� �ȵǴ��� �Ѥ�
	
	}
	
	
}
