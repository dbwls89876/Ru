package 평가2.정유진;

import java.util.ArrayList;

public  class CalcRank{
	
	public static ArrayList<Student> calcRank(ArrayList<Student> list){
		int[] rank = new int[list.size()];
		for(int i = 0; i<list.size(); i++) {
			for(int j = 0; j<list.size(); j++) {
				if(list.get(i).subject.getSum() < list.get(j).subject.getSum()) {
					rank[i]++;
				}
			}
		}
		
		for(int i = 0; i<list.size(); i++) {
			list.get(i).rank = rank[i] + 1;
		}
		
		return list;
	}
}
