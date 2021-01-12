package yn;

import java.util.ArrayList;

public class Rank {

	public void rank(ArrayList<Member> list) {

		int rank[] = new int[list.size()];
		
		for(int i = 0; i<list.size(); i++) {
			Member ri = list.get(i);
			for(int j = 0; j<list.size(); j++) {
				Member rj = list.get(j);
				if(ri.getMemberGrade().getBonusPoint()< rj.getMemberGrade().getBonusPoint())
					rank[i]++;
			}
		}
		
		for(int i = 0; i<list.size(); i++) {
			list.get(i).rank = rank[i];
		}
	}
}
