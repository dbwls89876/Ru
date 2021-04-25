package codingTest;

import java.util.ArrayList;
import java.util.Stack;

class Calculator{
	private int result;
	String op;
	ArrayList<String> posfix;
	Stack<Double> stack;
	boolean isError;
	//Stack<String> operator = new Stack<>(); 제대로 굴러가게 수정하기
	
	public Calculator() {
		posfix = new ArrayList<String>();
		posfix.add("0");
		stack = new Stack<Double>();
		result = 0;
		op = null;
		isError = false;
	}
	
	public Calculator add(int num) {
		if(op == null) // 연산자가 null이면 +연산자 추가
			op = "+";
		else // +연산자가 들어가있으면 stack에 +연산자 추가
			posfix.add("+");
		posfix.add(Integer.toString(num));
		return this;
	}
	
	public Calculator subtract(double num) { // 나누기가 먼저 되야함, 예외처리 0입력될 시 안되고있음
		posfix.add(Double.toString(num));
		if(op!=null) { // 나누기가 더하기 연산자보다 우선순위가 높아 먼저 add됨
			posfix.add("/");
			posfix.add("+");
			op = null; // +연산자가 빠져서 null
			return this;
		}
		posfix.add("/");
		return this;
	}
	
	public int out() {
		posfixCalculator();
		return result;
	}
	
	private void posfixCalculator() { // 후위 표기법으로 표현된 수식을 계산해주는 함수
		for(String token : posfix) {
			if(Character.isDigit(token.charAt(0))) { // token이 숫자인지 연산자인지를 판별한다.
				stack.push(Double.parseDouble(token)); // 숫자일 경우 stack에 push한다.
			}
			else {
				double n2 = stack.pop(); //2번째 숫자가 먼저나온다.
				double n1 = stack.pop();
				if(token.equals("+"))
					stack.push(n1+n2);
				else {
					isError = Double.isInfinite(n1/n2); //Double형은 0으로 나누어질 때 Exception으로 잡을 수 없기 때문에 infinite/isNaN 함수로 에러 발생 체크
					stack.push(n1/n2); //나눈 값 푸시
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
			System.out.println("0으로 나눌 수 없습니다.");
		else
			System.out.print(result);
	}

}
