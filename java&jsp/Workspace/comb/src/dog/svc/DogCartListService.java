package dog.svc;

import java.util.ArrayList;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import vo.Cart;

public class DogCartListService {

	public ArrayList<Cart> getCartList(HttpServletRequest request) {
		// TODO Auto-generated method stub
		HttpSession session = request.getSession();
		ArrayList<Cart>cartList = (ArrayList<Cart>)session.getAttribute("cartList");
		return cartList;
	}

}
