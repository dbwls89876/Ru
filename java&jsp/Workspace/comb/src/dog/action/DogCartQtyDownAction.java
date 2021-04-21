package dog.action;

import javax.servlet.http.HttpServletRequest;
import action.Action;
import javax.servlet.http.HttpServletResponse;

import dog.svc.DogCartQtyDownService;
import vo.ActionForward;

public class DogCartQtyDownAction implements Action {

	@Override
	public ActionForward execute(HttpServletRequest request, HttpServletResponse response) throws Exception {
		// TODO Auto-generated method stub
		String kind = request.getParameter("kind");
		DogCartQtyDownService dogCartQtyDownService = new DogCartQtyDownService();
		dogCartQtyDownService.downCartQty(kind, request);
		ActionForward forward = new ActionForward("dogShopping/dogCartList.dog", true);
		return forward;
	}

}
