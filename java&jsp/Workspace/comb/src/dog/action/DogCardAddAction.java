package dog.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import action.Action;
import dog.svc.DogCartAddService;
import vo.ActionForward;
import vo.Dog;

public class DogCardAddAction implements Action {

	@Override
	public ActionForward execute(HttpServletRequest request, HttpServletResponse response) throws Exception {
		// TODO Auto-generated method stub
		DogCartAddService dogCartAddService = new DogCartAddService();
		int id = Integer.parseInt(request.getParameter("id"));
		Dog cartDog = dogCartAddService.getCartDog(id);;
		dogCartAddService.addCart(request, cartDog);
		ActionForward forward = new ActionForward("dogShopping/dogCartList.dog", true);
		return forward;
	}

}
