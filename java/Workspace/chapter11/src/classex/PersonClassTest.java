package classex;

import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

public class PersonClassTest {

	public static void main(String[] args) throws ClassNotFoundException {
		Class personClass = Class.forName("classex.Person");
		
		Constructor[] cons = personClass.getConstructors();
		for(Constructor c : cons) {
			System.out.println(c);
		}
		
		System.out.println();
		Field[] fields = personClass.getFields();
		for(Field f : fields) {
			System.out.println(f);
		}
		System.out.println();
		Method[] methods = personClass.getMethods();
		for(Method m : methods) {
			System.out.println(m);
		}
	}

}
