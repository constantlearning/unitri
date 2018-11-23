package com.example.demo.controller;

public class MetricsResponse {

    private Double mu;
    private Double lambda;
    private Double probabilyOfServerBeingBusy;
    private Double averageTimeOfPermanenceInTheSystem;
    private Double averageTimeOfWaitingInTheSystem;
    private Double averageOfClientsInTheSystem;
    private Double averageOfClientsInTheQueue;

    public MetricsResponse() {
    }

    public MetricsResponse(Double mu, Double lambda, Double probabilyOfServerBeingBusy,
                           Double averageTimeOfPermanenceInTheSystem, Double averageTimeOfWaitingInTheSystem,
                           Double averageOfClientsInTheSystem, Double averageOfClientsInTheQueue) {
        this.mu = mu;
        this.lambda = lambda;
        this.probabilyOfServerBeingBusy = probabilyOfServerBeingBusy;
        this.averageTimeOfPermanenceInTheSystem = averageTimeOfPermanenceInTheSystem;
        this.averageTimeOfWaitingInTheSystem = averageTimeOfWaitingInTheSystem;
        this.averageOfClientsInTheSystem = averageOfClientsInTheSystem;
        this.averageOfClientsInTheQueue = averageOfClientsInTheQueue;
    }

    public Double getMu() {
        return mu;
    }

    public void setMu(Double mu) {
        this.mu = mu;
    }

    public Double getLambda() {
        return lambda;
    }

    public void setLambda(Double lambda) {
        this.lambda = lambda;
    }

    public Double getProbabilyOfServerBeingBusy() {
        return probabilyOfServerBeingBusy;
    }

    public void setProbabilyOfServerBeingBusy(Double probabilyOfServerBeingBusy) {
        this.probabilyOfServerBeingBusy = probabilyOfServerBeingBusy;
    }

    public Double getAverageTimeOfPermanenceInTheSystem() {
        return averageTimeOfPermanenceInTheSystem;
    }

    public void setAverageTimeOfPermanenceInTheSystem(Double averageTimeOfPermanenceInTheSystem) {
        this.averageTimeOfPermanenceInTheSystem = averageTimeOfPermanenceInTheSystem;
    }

    public Double getAverageTimeOfWaitingInTheSystem() {
        return averageTimeOfWaitingInTheSystem;
    }

    public void setAverageTimeOfWaitingInTheSystem(Double averageTimeOfWaitingInTheSystem) {
        this.averageTimeOfWaitingInTheSystem = averageTimeOfWaitingInTheSystem;
    }

    public Double getAverageOfClientsInTheSystem() {
        return averageOfClientsInTheSystem;
    }

    public void setAverageOfClientsInTheSystem(Double averageOfClientsInTheSystem) {
        this.averageOfClientsInTheSystem = averageOfClientsInTheSystem;
    }

    public Double getAverageOfClientsInTheQueue() {
        return averageOfClientsInTheQueue;
    }

    public void setAverageOfClientsInTheQueue(Double averageOfClientsInTheQueue) {
        this.averageOfClientsInTheQueue = averageOfClientsInTheQueue;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        final MetricsResponse that = (MetricsResponse) o;

        if (mu != null ? !mu.equals(that.mu) : that.mu != null) return false;
        if (lambda != null ? !lambda.equals(that.lambda) : that.lambda != null) return false;
        if (probabilyOfServerBeingBusy != null ? !probabilyOfServerBeingBusy.equals(that.probabilyOfServerBeingBusy) : that.probabilyOfServerBeingBusy != null)
            return false;
        if (averageTimeOfPermanenceInTheSystem != null ? !averageTimeOfPermanenceInTheSystem.equals(that.averageTimeOfPermanenceInTheSystem) : that.averageTimeOfPermanenceInTheSystem != null)
            return false;
        if (averageTimeOfWaitingInTheSystem != null ? !averageTimeOfWaitingInTheSystem.equals(that.averageTimeOfWaitingInTheSystem) : that.averageTimeOfWaitingInTheSystem != null)
            return false;
        if (averageOfClientsInTheSystem != null ? !averageOfClientsInTheSystem.equals(that.averageOfClientsInTheSystem) : that.averageOfClientsInTheSystem != null)
            return false;
        return averageOfClientsInTheQueue != null ? averageOfClientsInTheQueue.equals(that.averageOfClientsInTheQueue) : that.averageOfClientsInTheQueue == null;
    }

    @Override
    public int hashCode() {
        int result = mu != null ? mu.hashCode() : 0;
        result = 31 * result + (lambda != null ? lambda.hashCode() : 0);
        result = 31 * result + (probabilyOfServerBeingBusy != null ? probabilyOfServerBeingBusy.hashCode() : 0);
        result = 31 * result + (averageTimeOfPermanenceInTheSystem != null ? averageTimeOfPermanenceInTheSystem.hashCode() : 0);
        result = 31 * result + (averageTimeOfWaitingInTheSystem != null ? averageTimeOfWaitingInTheSystem.hashCode() : 0);
        result = 31 * result + (averageOfClientsInTheSystem != null ? averageOfClientsInTheSystem.hashCode() : 0);
        result = 31 * result + (averageOfClientsInTheQueue != null ? averageOfClientsInTheQueue.hashCode() : 0);
        return result;
    }

    @Override
    public String toString() {
        return "MetricsResponse{" +
                "mu=" + mu +
                ", lambda=" + lambda +
                ", probabilyOfServerBeingBusy=" + probabilyOfServerBeingBusy +
                ", averageTimeOfPermanenceInTheSystem=" + averageTimeOfPermanenceInTheSystem +
                ", averageTimeOfWaitingInTheSystem=" + averageTimeOfWaitingInTheSystem +
                ", averageOfClientsInTheSystem=" + averageOfClientsInTheSystem +
                ", averageOfClientsInTheQueue=" + averageOfClientsInTheQueue +
                '}';
    }
}
