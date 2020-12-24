package test;

import school.School;
import school.Score;
import school.Student;
import school.Subject;
import school.report.GenerateGradeReport;
import utils.Define;

public class TestMain {
	School goodSchool = School.getInstance();
	Subject korean;
	Subject math;
	Subject dance;
	GenerateGradeReport gradeReport = new GenerateGradeReport();
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		TestMain test = new TestMain();
		
		test.createSubject();
		test.createStudent();
		
		String report = test.gradeReport.getReport();
		System.out.println(report);
	}
	
	public void createSubject() {
		korean = new Subject("국어", Define.KOREAN);
		math = new Subject("수학", Define.MATH);
		dance = new Subject("방송 댄스", Define.DANCE);
		goodSchool.addSubject(korean);
		goodSchool.addSubject(math);
		goodSchool.addSubject(dance);
	}
	
	public void createStudent() {
		Student student1 = new Student(181213, "안성원", korean);
		Student student2 = new Student(181518, "오태훈", math);
		Student student3 = new Student(171230, "이동호", korean);
		Student student4 = new Student(171255, "조성욱", korean);
		Student student5 = new Student(171590, "최태평", math);
		
		goodSchool.addStudent(student1);
		goodSchool.addStudent(student2);
		goodSchool.addStudent(student3);
		goodSchool.addStudent(student4);
		goodSchool.addStudent(student5);
		
		korean.resister(student1);
		korean.resister(student2);
		korean.resister(student3);
		korean.resister(student4);
		korean.resister(student5);
		
		math.resister(student1);
		math.resister(student2);
		math.resister(student3);
		math.resister(student4);
		math.resister(student5);
		
		dance.resister(student1);
		dance.resister(student2);
		dance.resister(student3);
		
		addScoreForStudent(student1, korean, 95);
		addScoreForStudent(student1, math, 56);
		addScoreForStudent(student1, dance, 95);
		
		addScoreForStudent(student2, korean, 95);
		addScoreForStudent(student2, math, 95);
		addScoreForStudent(student2, dance, 85);
		
		addScoreForStudent(student3, korean, 100);
		addScoreForStudent(student3, math, 88);
		addScoreForStudent(student3, dance, 55);
		
		addScoreForStudent(student4, korean, 89);
		addScoreForStudent(student4, math, 95);
		
		addScoreForStudent(student5, korean, 85);
		addScoreForStudent(student5, math, 56);
	}
	
	public void addScoreForStudent(Student student, Subject subject, int point) {
		Score score = new Score(student.getStudentID(), subject, point);
		student.addSubjectScore(score);
	}
}
