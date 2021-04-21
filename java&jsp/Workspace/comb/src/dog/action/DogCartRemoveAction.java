package dog.action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import action.Action;
import dog.svc.DogCartRemoveService;
import vo.ActionForward;

public class DogCartRemoveAction implements Action {

	@Override
	public ActionForward execute(HttpServletRequest request, HttpServletResponse response) throws Exception {
		// TODO Auto-generated method stub
		String[] kindArray = request.getParameterValues("remove");
		DogCartRemoveService dogCartRemoveService = new DogCartRemoveService();
		dogCartRemoveService.cartRemove(request, kindArray);
		ActionForward forward = new ActionForward("dogShopping/dogCartList.dog", true);
		//*****dog 주소값 나중에 작동 안될 시 확인 부탁
		return forward;
	}

}
