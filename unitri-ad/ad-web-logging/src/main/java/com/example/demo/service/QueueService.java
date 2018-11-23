package com.example.demo.service;

import com.example.demo.controller.MetricsResponse;
import com.example.demo.domain.MM1Queue;
import com.example.demo.repository.Log;
import com.example.demo.repository.LogRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.sql.Timestamp;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class QueueService {

    private final LogRepository logRepository;

    @Autowired
    public QueueService(LogRepository logRepository) {
        this.logRepository = logRepository;
    }

    public MetricsResponse calculate(Timestamp startDate, Timestamp endDate, Integer unit) {

        List<Log> logs = this.logRepository.findAllByChegadaAfterAndSaidaBefore(startDate, endDate);

        List<Log> chegadas = logs.stream()
                .filter(x ->  x.getChegada().after(startDate) || x.getChegada().equals(startDate))
                .collect(Collectors.toList());

        List<Log> saidas = logs.stream()
                .filter(x -> x.getSaida().before(endDate) || x.getSaida().equals(endDate))
                .collect(Collectors.toList());

        MM1Queue queue = new MM1Queue(chegadas.size(), saidas.size(), unit);

        return new MetricsResponse(
                queue.getMu(),
                queue.getLambda(),
                queue.probabilyOfServerBeingBusy(),
                queue.averageTimeOfPermanenceInTheSystem(),
                queue.averageTimeOfWaitingInTheSystem(),
                queue.averageOfClientsInTheSystem(),
                queue.averageOfClientsInTheQueue()
        );
    }
}
