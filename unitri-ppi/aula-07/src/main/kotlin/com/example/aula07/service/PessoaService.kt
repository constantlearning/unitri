package com.example.aula07.service

import com.example.aula07.model.Pessoa
import com.example.aula07.repository.PessoaRepository
import org.springframework.stereotype.Service


@Service
class PessoaService(
    val repository: PessoaRepository
) {

    fun findAll(): List<Pessoa> = repository.findAll()

    fun findOne(id: Long): Pessoa = repository.getOne(id)

    fun save(post: Pessoa): Pessoa = repository.saveAndFlush(post)

    fun delete(id: Long) = repository.deleteById(id)
}