package com.example.aula07.model

import javax.persistence.Entity
import javax.persistence.GeneratedValue
import javax.persistence.Id

@Entity
data class Pessoa(
    @Id
    @GeneratedValue
    val id: Long = 0L,
    val nome: String = "",
    val cpf: String = "",
    val telefone: String = ""
)