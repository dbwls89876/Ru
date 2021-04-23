package codingTest;

import java.util.Stack;

class Calculator{
	int result = 0;
	Stack<Integer> stack = new Stack<Integer>();
	//Stack<String> operator = new Stack<>(); ����� �������� �����ϱ�
	
	public Calculator add(int num) {
		stack.add(num);
		return this;
	}
	
	public Calculator subtract(double num) { // �����Ⱑ ���� �Ǿ���, ����ó�� 0�Էµ� �� �ȵǰ�����
		try {
			result += Math.round(stack.pop()/num);
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
		return this;
	}
	public int out() {
		if(!stack.empty()) 
			result += stack.pop();
		return result;
	}
}

public class second {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Calculator calculator = new Calculator();
		int result = calculator.add(4).add(5).subtract(3).out();
		System.out.print(result);
	}

}
