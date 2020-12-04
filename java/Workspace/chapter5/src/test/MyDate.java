package test;

public class MyDate {
	private int day, month, year;
	private boolean valid = true;
	public MyDate(int day, int month, int year) {
		setYear(year);
		setMonth(month);
		setDay(day);
	}
	
	public String isValid() {
		String str;
		if(valid) {
			str = "유효한 날짜입니다.";
		}
		else {
			str = "유효하지 않은 날짜입니다.";
		}
			
		return str;
	}
	
	public int getDay() {
		return day;
	}

	public void setDay(int day) {
		
		if(month==2)
			if(day<1||day>28) {
				valid = false;
				return;
			}
		else if(day<1||day>31) {
			valid = false;
			return;
		}
		else {
			this.day = day;
		}
			
	}

	public int getMonth() {
		return month;
	}

	public void setMonth(int month) {
		if(month<1||month>12) {
			valid = false;
			return;
		}
		else {
			this.month = month;
		}
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}
	
}
