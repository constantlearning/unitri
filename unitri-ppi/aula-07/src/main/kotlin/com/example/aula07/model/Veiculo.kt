package com.example.aula07.model

import javax.persistence.Entity
import javax.persistence.GeneratedValue
import javax.persistence.Id

@Entity
data class Veiculo(
    @Id
    @GeneratedValue
    val id: Long = 0L,
    val chassi: String = "",
    val placa: String = "",
    val marca: String = "",
    val modelo: String = ""
)