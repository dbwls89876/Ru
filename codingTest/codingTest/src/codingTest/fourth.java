package codingTest;

import java.util.stream.Stream;
//
//@FunctionalInterface
//interface TailCall{
//    TailCall apply();
//    default boolean isComplete() {
//        return false;
//    }
//    default long result() {
//        throw new Error("결과없음");
//    }
//    default long invoke() {
//        return Stream.iterate(this, TailCall::apply)
//                .filter(TailCall::isComplete)
//                .findFirst()
//                .get()
//                .result();
//    }
//}
//
//class TailCalls{
//    public static TailCall call(final TailCall nextCall) {
//        return nextCall;
//    }
//
//    public static TailCall done(final long value) {
//        return new TailCall() {
//            @Override
//            public boolean isComplete() {
//                return true;
//            }
//
//            @Override
//            public long result() {
//                return value;
//            }
//
//            @Override
//            public TailCall apply() {
//                throw new Error("결과없음");
//            }
//        };
//    }
//}
//
public class fourth {
//
//public static TailCall factorial(long n, long tail) {
//	if(n==1) return TailCalls.done(tail);
//	else return TailCalls.call(() -> factorial(n-1, n * tail));
//}
//
//
//public static int factorial(int n) {
//	int a;
//	
//	if(n==1)
//		return n;
//	else {
//		a=n;
//		for(int i = n-1; i>0; i--)
//			a *=i;
//		return a;
//	}
//}

	public static int factorial(int n, int tail) {
		if(n<=1) return tail;  // 꼬리 재귀 활용
		return factorial(n-1, tail*n);
	}
	
	public static int factorial(int n) {
		return factorial(n, 1);
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String result = Integer.toHexString(factorial(10000));
		System.out.println(result); //스택 오버 플로우는 발생하지 않지만 출력 불가, 리스트를 사용해서 문자열로 출력해보기
		//System.out.println(factorial(100, 1).invoke());
	}

}