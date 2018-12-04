package com.example.aula07.service

import com.example.aula07.model.Veiculo
import com.example.aula07.repository.VeiculoRepository
import org.springframework.stereotype.Service


@Service
class VeiculoService(
    val repository: VeiculoRepository
) {

    fun findAll(): List<Veiculo> = repository.findAll()

    fun findOne(id: Long): Veiculo = repository.getOne(id)

    fun save(post: Veiculo): Veiculo = repository.saveAndFlush(post)

    fun delete(id: Long) = repository.deleteById(id)
}