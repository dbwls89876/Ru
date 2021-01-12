package yn.grade;

import java.util.ArrayList;

public class GradeTest {

	public static void main(String[] args) {
		ArrayList<MemberGrade> list = new ArrayList<MemberGrade>();
		list.add(new MemberGrade());
		list.add(new SilverGrade(1500));
		list.add(new SilverGrade());
		
		for(MemberGrade i : list) {
			System.out.println(i.showGradeInfo());
		}
	}

}
