package com.example.demo.domain;

public interface QueueOperations {

    Double rateOfArrival(Double quantity, int unit); // Lambda
    Double serviceRate(Double quantity, int unit); // Mu
    Double probabilyOfServerBeingBusy(); // P
    Double averageTimeOfPermanenceInTheSystem(); // W
    Double averageTimeOfWaitingInTheSystem(); // Wq
    Double averageOfClientsInTheSystem(); // L
    Double averageOfClientsInTheQueue(); // Lq
    Double probabilityToHaveNClientsInQueue(Integer quantity); // PI(n)
    Double probabilityOfNIsGreatterThenK(Integer quantity); // P(N > K)
    Double probabilityRate(Integer value);
}
