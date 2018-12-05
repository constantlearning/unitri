
package com.example.aulasspring.service;

import com.example.aulasspring.model.Pessoa;
import com.example.aulasspring.repository.PessoaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;


@Service
public class PessoaService {

    @Autowired
    private PessoaRepository repository;

    public List<Pessoa> findAll() {
        return repository.findAll();
    }

    public Pessoa findOne(Long id) {
        return (Pessoa) repository.getOne(id);
    }

    public Pessoa save(Pessoa post) {
        return (Pessoa) repository.saveAndFlush(post);
    }

    public void delete(Long id) {
        repository.deleteById(id);
    }
}
