package codingTest;

import java.util.ArrayList;
import java.util.Stack;

class Calculator{
	private int result;
	String op;
	ArrayList<String> posfix;
	Stack<Double> stack;
	boolean isError;
	//Stack<String> operator = new Stack<>(); ����� �������� �����ϱ�
	
	public Calculator() {
		posfix = new ArrayList<String>();
		posfix.add("0");
		stack = new Stack<Double>();
		result = 0;
		op = null;
		isError = false;
	}
	
	public Calculator add(int num) {
		if(op == null) // �����ڰ� null�̸� +������ �߰�
			op = "+";
		else // +�����ڰ� �������� stack�� +������ �߰�
			posfix.add("+");
		posfix.add(Integer.toString(num));
		return this;
	}
	
	public Calculator subtract(double num) { // �����Ⱑ ���� �Ǿ���, ����ó�� 0�Էµ� �� �ȵǰ�����
		posfix.add(Double.toString(num));
		if(op!=null) { // �����Ⱑ ���ϱ� �����ں��� �켱������ ���� ���� add��
			posfix.add("/");
			posfix.add("+");
			op = null; // +�����ڰ� ������ null
			return this;
		}
		posfix.add("/");
		return this;
	}
	
	public int out() {
		posfixCalculator();
		return result;
	}
	
	private void posfixCalculator() { // ���� ǥ������� ǥ���� ������ ������ִ� �Լ�
		for(String token : posfix) {
			if(Character.isDigit(token.charAt(0))) { // token�� �������� ������������ �Ǻ��Ѵ�.
				stack.push(Double.parseDouble(token)); // ������ ��� stack�� push�Ѵ�.
			}
			else {
				double n2 = stack.pop(); //2��° ���ڰ� �������´�.
				double n1 = stack.pop();
				if(token.equals("+"))
					stack.push(n1+n2);
				else {
					isError = Double.isInfinite(n1/n2); //Double���� 0���� �������� �� Exception���� ���� �� ���� ������ infinite/isNaN �Լ��� ���� �߻� üũ
					stack.push(n1/n2); //���� �� Ǫ��
				}
			}
		}
		this.result = (int)Math.round(stack.pop());
	}
}

public class second {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Calculator calculator = new Calculator();
		int result = calculator.add(4).add(5).subtract(3).out();
		if(calculator.isError)
			System.out.println("0���� ���� �� �����ϴ�.");
		else
			System.out.print(result);
	}

}
