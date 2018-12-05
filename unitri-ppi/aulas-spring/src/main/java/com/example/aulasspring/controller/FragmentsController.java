
package com.example.aulasspring.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class FragmentsController {

    @GetMapping("/fragments")
    public String getHome() {
        return "fragments.html";
    }
}