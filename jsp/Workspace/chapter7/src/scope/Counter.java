package scope;

public class Counter {
	private int cnt=0;

	public int getCnt() {
		this.cnt++;
		return cnt;
	}

	public void setCnt(int cnt) {
		this.cnt=cnt;
	}
	
	
}
