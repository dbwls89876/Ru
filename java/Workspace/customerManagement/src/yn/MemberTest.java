package yn;

import java.util.ArrayList;

import yn.grade.SilverGrade;

public class MemberTest {

	public static void main(String[] args) {
		ArrayList<Member> mb = new ArrayList<Member>();
		Member hong = new Member("a111", "ȫ�浿", "1111");
		Member go = new Member("b111", "��浿", "2222");
		Member hongs = new Member("c111", "ȫ���", "3333");
		go.setMemberGrade(new SilverGrade(2000));
		hongs.setMemberGrade(new SilverGrade());
		
		hong.getMemberGrade().calcPrice(10000);

		mb.add(hong);
		mb.add(go);
		mb.add(hongs);
		Rank r = new Rank();
		r.rank(mb);
		
		for(int i = 0; i<mb.size(); i++) {
			Member m = mb.get(i);
			m.showInfo();
		}
	}

}
