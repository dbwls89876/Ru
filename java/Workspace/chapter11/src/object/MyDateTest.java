package object;

class MyDate{
	int day;
	int month;
	int year;
	
	public MyDate(int day, int month, int year) {
		this.day = day;
		this.month = month;
		this.year = year;
	}
	
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof MyDate) {
			MyDate md = (MyDate)obj;
			if(this.day == md.day && this.month == md.month && this.year == md.year)
				return true;
			else
				return false;
		}
		return false;
	}
	
	@Override
	public int hashCode() {
		return (this.year*10000)+(this.month*100)+this.day;
	}
}

public class MyDateTest {
	public static void main(String[] args) {
		MyDate date1 = new MyDate(18, 9, 2004);
		MyDate date2 = new MyDate(18, 9, 2004);
		System.out.println(date1.equals(date2));
		System.out.println(date1.hashCode());
	}
}
