package com.example.aula07.controller

import com.example.aula07.model.Veiculo
import com.example.aula07.service.VeiculoService
import org.springframework.stereotype.Controller
import org.springframework.validation.BindingResult
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PathVariable
import org.springframework.web.bind.annotation.PostMapping
import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.servlet.ModelAndView
import javax.validation.Valid


@Controller
@RequestMapping("/veiculos")
class VeiculoController(
    val service: VeiculoService
) {

    @GetMapping
    fun findAll(): ModelAndView =
        ModelAndView("/veiculos").addObject("veiculos", service.findAll())

    @GetMapping("/add")
    fun add(veiculo: Veiculo): ModelAndView = ModelAndView("/veiculo").addObject("veiculo", veiculo)

    @GetMapping("/edit/{id}")
    fun edit(@PathVariable("id") id: Long): ModelAndView = add(service.findOne(id))

    @GetMapping("/delete/{id}")
    fun delete(@PathVariable("id") id: Long): ModelAndView {
        service.delete(id)
        return findAll()
    }

    @PostMapping("/save")
    fun save(@Valid veiculo: Veiculo, result: BindingResult): ModelAndView {

        if (result.hasErrors()) {
            return add(veiculo)
        }
        service.save(veiculo)
        return findAll()
    }

}