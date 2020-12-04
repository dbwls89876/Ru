package chapter3;

public class OperationEx2 {
	public static void main(String[] args) {
		int gameScore = 150;
		System.out.print("lastScore1 = ++gmaeScore 角青:: ");
		int lastScore1 = ++gameScore;
		System.out.println("lastScore1 : " + lastScore1 + ", "+"gameSocre : " + gameScore);
		System.out.print("lastScore1 = gmaeScore++ 角青:: ");
		lastScore1 = gameScore++;
		System.out.println("lastScore1 : " + lastScore1 + ", "+"gameSocre : " + gameScore);
		System.out.print("lastScore2 = --gmaeScore 角青:: ");
		int lastScore2 = --gameScore;
		System.out.println("lastScore2 : " + lastScore2 + ", "+"gameSocre : " + gameScore);
		System.out.print("lastScore2 = gmaeScore-- 角青:: ");
		lastScore2 = gameScore--;
		System.out.println("lastScore2 : " + lastScore2 + ", "+"gameSocre : " + gameScore);
	}
}
