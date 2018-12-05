
package com.example.aulasspring.service;


import com.example.aulasspring.model.Categoria;
import com.example.aulasspring.repository.CategoriaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class CategoriaService {

    @Autowired
    private CategoriaRepository repository;

    public List<Categoria> findAll() {
        return repository.findAll();
    }

    public Categoria findOne(Long id) {
        return repository.getOne(id);
    }

    public Categoria save(Categoria cat) {
        return repository.saveAndFlush(cat);
    }

    public void delete(Long id) {
        repository.deleteById(id);
    }
}
