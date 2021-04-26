package codingTest;

import java.util.stream.Stream;

@FunctionalInterface
interface Tail{
    Tail apply();
    default boolean isComplete() {
        return false;
    }
    default long result() {
        throw new Error("error");
    }
    default long invoke() {
        long r =  Stream.iterate(this, Tail::apply) // iterate에서 계산이 진행된다
                .filter(Tail::isComplete) // true가 반환될때까지 반복
                .findFirst()
                .get()
                .result();
        System.out.println(r);
        return r;
    }
}

class Tails{
    public static Tail call(final Tail nextCall) {
        return nextCall;
    }

    public static Tail done(final long value) {
        return new Tail() {
            @Override
            public boolean isComplete() { // 계산이 완료되었을 때 true를 반환
                return true;
            }

            @Override
            public long result() { // 계산 결과값 반환
                return value;
            }

            @Override
            public Tail apply() {
                throw new Error("error");
            }
        };
    }
}

public class fourth {
//
	public static Tail factorial(long n, long tail) {
		if(n==1) return Tails.done(tail); // done에서 재정의된 함수들이 반환된다
		else return Tails.call(() -> factorial(n-1, n * tail)); // Tails의 call함수에 Tail 변수 리턴
	}
	
	
	public static int factorial(int n) {
		int tail;
		
		if(n==1)
			return n;
		else {
			tail=n;
			for(int i = n-1; i>0; i--)
				tail *=i;
			return tail;
		}
	}

	public static int factorialTail1(int n, int tail) {
		if(n<=1) return tail;  // 꼬리 재귀 활용 오버플로우발생함
		return factorialTail1(n-1, tail*n);
	}
	
	public static int factorial1(int n) {
		return factorialTail1(n, 1);
	}
	
	public static int factorialTail2(int n){
	    int tail = 1;
	    do
	    {
	        if (n == 1) return tail;
	        tail = tail * n;
	        System.out.println(tail);
	        n = n - 1;
	    }while (true);
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//factorialTail1(1000000); 자바에서는 꼬리재귀 최적화를 지원하지 않음
		//System.out.println(factorialTail2(1000000)); //꼬리재귀를 사용했을 때 일반적으로 컴파일러에서 받아들이는 것
		//System.out.println(factorial(1000000));// 단순 반복문
		
		
		factorial(5, 1).invoke(); // 람다식을 이용해 구현, 스택오버플로우 발생 x
	}

}