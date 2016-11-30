package pl.wat.ai.library.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;


@Controller
public class WelcomeController {

	
	@RequestMapping("/welcome")
	public ModelAndView helloWorld() {
		
 
		String message ="Welcome" ;
		return new ModelAndView("welcome", "message", message);
	}
	
	@RequestMapping("/welcome1")
	public String helloWorld1() {
 
		String message ="Welcome" ;
		return "welcome1";
	}
	
}
