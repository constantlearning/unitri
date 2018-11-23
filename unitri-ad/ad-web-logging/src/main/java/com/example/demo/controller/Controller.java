package com.example.demo.controller;

import com.example.demo.repository.Log;
import com.example.demo.repository.LogRepository;
import com.example.demo.service.QueueService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.sql.Timestamp;
import java.time.Instant;

@RestController
@RequestMapping("/")
public class Controller {

    private final LogRepository logRepository;
    private final QueueService queueService;

    @Autowired
    public Controller(LogRepository logRepository, QueueService queueService) {
        this.logRepository = logRepository;
        this.queueService = queueService;
    }

    @GetMapping
    public Log doSomething() {

        Timestamp in = Timestamp.from(Instant.now());
        randomDelay();
        Timestamp out = Timestamp.from(Instant.now());

        Long tempoServico = out.getTime() - in.getTime();

        return logRepository.save(new Log(in, out, tempoServico));
    }

    @PostMapping("metrics")
    public MetricsResponse calculateBetweenInterval(@RequestBody MetricsRequest request) {

        Timestamp startTime = Timestamp.valueOf(request.getStartTime());
        Timestamp endTime = Timestamp.valueOf(request.getEndTime());
        Integer unit = request.getUnit();

        return queueService.calculate(startTime, endTime, unit);
    }

    private void randomDelay() {
        int random = (int) (5 * Math.random() + 1);
        try {
            Thread.sleep(random * 1000);
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
            e.printStackTrace();
        }
    }

}