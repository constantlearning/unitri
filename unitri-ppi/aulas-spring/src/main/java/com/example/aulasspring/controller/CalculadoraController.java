
package com.example.aulasspring.controller;

import com.example.aulasspring.model.CalcModel;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

@Controller
@RequestMapping(value = "/calcs")
public class CalculadoraController {

    @RequestMapping(method = RequestMethod.GET)
    public ModelAndView calc() {

        ModelAndView mv = new ModelAndView("/calc");
        mv.addObject("calcModel", new CalcModel());

        return mv;
    }

    @RequestMapping(method = RequestMethod.POST)
    public ModelAndView calc(CalcModel calcModel) {

        ModelAndView mv = new ModelAndView("/calc");
        calcModel.calcula();
        mv.addObject("calcModel", calcModel);

        return mv;
    }
}
