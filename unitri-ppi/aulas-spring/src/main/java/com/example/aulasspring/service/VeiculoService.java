
package com.example.aulasspring.service;

import com.example.aulasspring.model.Veiculo;
import com.example.aulasspring.repository.VeiculoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class VeiculoService {

    @Autowired
    private VeiculoRepository repository;

    public List<Veiculo> findAll() {
        return repository.findAll();
    }

    public Veiculo findOne(Long id) {
        return repository.getOne(id);
    }

    public Veiculo save(Veiculo vei) {
        return repository.saveAndFlush(vei);
    }

    public void delete(Long id) {
        repository.deleteById(id);
    }
}
