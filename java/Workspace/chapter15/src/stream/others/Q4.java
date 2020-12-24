package stream.others;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.Writer;

public class Q4 {

	public static void main(String[] args) throws FileNotFoundException, IOException {


		try(FileOutputStream fos = new FileOutputStream("a.txt");
				Writer osw = new OutputStreamWriter(fos)) {
			osw.write("지금까지 자바 정말 재미있게 공부했어요^^");
		}catch(IOException e) {
			e.printStackTrace();
		}
	}

}
