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
        long r =  Stream.iterate(this, Tail::apply) // iterate���� ����� ����ȴ�
                .filter(Tail::isComplete) // true�� ��ȯ�ɶ����� �ݺ�
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
            public boolean isComplete() { // ����� �Ϸ�Ǿ��� �� true�� ��ȯ
                return true;
            }

            @Override
            public long result() { // ��� ����� ��ȯ
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
		if(n==1) return Tails.done(tail); // done���� �����ǵ� �Լ����� ��ȯ�ȴ�
		else return Tails.call(() -> factorial(n-1, n * tail)); // Tails�� call�Լ��� Tail ���� ����
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
		if(n<=1) return tail;  // ���� ��� Ȱ�� �����÷ο�߻���
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
		//factorialTail1(1000000); �ڹٿ����� ������� ����ȭ�� �������� ����
		//System.out.println(factorialTail2(1000000)); //������͸� ������� �� �Ϲ������� �����Ϸ����� �޾Ƶ��̴� ��
		//System.out.println(factorial(1000000));// �ܼ� �ݺ���
		
		
		factorial(5, 1).invoke(); // ���ٽ��� �̿��� ����, ���ÿ����÷ο� �߻� x
	}

}