package com.example.demo.repository;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.sql.Timestamp;

@Entity
public class Log {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private Timestamp chegada;

    private Timestamp saida;

    private Long tempoDeServico;

    public Log() {
    }

    public Log(Timestamp chegada, Timestamp saida, Long tempoDeServico) {
        this.chegada = chegada;
        this.saida = saida;
        this.tempoDeServico = tempoDeServico;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Timestamp getChegada() {
        return chegada;
    }

    public void setChegada(Timestamp chegada) {
        this.chegada = chegada;
    }

    public Timestamp getSaida() {
        return saida;
    }

    public void setSaida(Timestamp saida) {
        this.saida = saida;
    }

    public Long getTempoDeServico() {
        return tempoDeServico;
    }

    public void setTempoDeServico(Long tempoDeServico) {
        this.tempoDeServico = tempoDeServico;
    }
}
