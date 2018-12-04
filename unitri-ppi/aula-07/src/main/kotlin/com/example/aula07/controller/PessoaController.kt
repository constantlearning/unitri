package com.example.aula07.controller

import com.example.aula07.model.Pessoa
import com.example.aula07.service.PessoaService
import org.springframework.stereotype.Controller
import org.springframework.validation.BindingResult
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PathVariable
import org.springframework.web.bind.annotation.PostMapping
import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.servlet.ModelAndView
import javax.validation.Valid


@Controller
@RequestMapping("/pessoas")
class PessoaController(
    val service: PessoaService
) {

    @GetMapping
    fun findAll(): ModelAndView =
        ModelAndView("/pessoas").addObject("pessoas", service.findAll())

    @GetMapping("/add")
    fun add(pessoa: Pessoa): ModelAndView = ModelAndView("/pessoa").addObject("pessoa", pessoa)

    @GetMapping("/edit/{id}")
    fun edit(@PathVariable("id") id: Long): ModelAndView = add(service.findOne(id))

    @GetMapping("/delete/{id}")
    fun delete(@PathVariable("id") id: Long): ModelAndView {
        service.delete(id)
        return findAll()
    }

    @PostMapping("/save")
    fun save(@Valid pessoa: Pessoa, result: BindingResult): ModelAndView {

        if (result.hasErrors()) {
            return add(pessoa)
        }
        service.save(pessoa)
        return findAll()
    }

}