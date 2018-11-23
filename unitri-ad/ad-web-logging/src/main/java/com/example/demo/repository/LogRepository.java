package com.example.demo.repository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.sql.Timestamp;
import java.util.List;

@Repository
public interface LogRepository extends CrudRepository<Log, Long> {

    List<Log> findAllByChegadaAfterAndSaidaBefore(Timestamp chegada, Timestamp saida);
}
