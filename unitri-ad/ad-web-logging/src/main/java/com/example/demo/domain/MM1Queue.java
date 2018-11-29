package com.example.demo.domain;

import com.google.common.math.DoubleMath;

public class MM1Queue implements QueueOperations {

    private Double lambda;
    private Double mu;

    public MM1Queue(Integer chegadas, Integer saidas, int unidadeDeTempo) {
        this.lambda = this.rateOfArrival(Double.valueOf(chegadas), unidadeDeTempo);
        this.mu = 200D;
//        this.mu = this.serviceRate(Double.valueOf(saidas), unidadeDeTempo);
    }

    public Double getLambda() {
        return lambda;
    }

    public Double getMu() {
        return mu;
    }

    @Override
    public Double rateOfArrival(Double quantity, int unit) {
        return quantity / unit;
    }

    @Override
    public Double serviceRate(Double quantity, int unit) {
        return quantity / unit;
    }

    @Override
    public Double probabilyOfServerBeingBusy() {
        return lambda / mu;
    }

    @Override
    public Double averageTimeOfPermanenceInTheSystem() {
        return 1 / (mu / lambda);
    }

    @Override
    public Double averageTimeOfWaitingInTheSystem() {
        return lambda / (mu * (mu / lambda));
    }

    @Override
    public Double averageOfClientsInTheSystem() {
        return lambda / (mu - lambda);
    }

    @Override
    public Double averageOfClientsInTheQueue() {
        return Math.pow(lambda, 2) / (mu * (mu - lambda));
    }

    @Override
    public Double probabilityToHaveNClientsInQueue(Integer quantity) {
        return Math.pow((lambda / mu), quantity) * ((mu / lambda) / mu);
    }

    @Override
    public Double probabilityOfNIsGreatterThenK(Integer quantity) {
        System.out.println(lambda/mu);
        return Math.pow((lambda / mu), quantity + 1);

    }

    @Override
    public Double probabilityRate(Integer value) {
        return Math.pow(lambda, value) * Math.pow(Math.E, -lambda) / DoubleMath.factorial(value);
    }

    @Override
    public String toString() {
        return "MM1Queue{" +
                "lambda=" + lambda +
                ", mu=" + mu +
                '}';
    }
}