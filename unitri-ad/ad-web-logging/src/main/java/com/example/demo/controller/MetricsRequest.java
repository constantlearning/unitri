package com.example.demo.controller;

import java.time.LocalDateTime;

public class MetricsRequest {

    private LocalDateTime startTime;
    private LocalDateTime endTime;
    private Integer unit;

    public MetricsRequest() {
    }

    public MetricsRequest(LocalDateTime startTime, LocalDateTime endTime, Integer unit) {
        this.startTime = startTime;
        this.endTime = endTime;
        this.unit = unit;
    }

    public LocalDateTime getStartTime() {
        return startTime;
    }

    public void setStartTime(LocalDateTime startTime) {
        this.startTime = startTime;
    }

    public LocalDateTime getEndTime() {
        return endTime;
    }

    public void setEndTime(LocalDateTime endTime) {
        this.endTime = endTime;
    }

    public Integer getUnit() {
        return unit;
    }

    public void setUnit(Integer unit) {
        this.unit = unit;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        final MetricsRequest that = (MetricsRequest) o;

        if (startTime != null ? !startTime.equals(that.startTime) : that.startTime != null) return false;
        if (endTime != null ? !endTime.equals(that.endTime) : that.endTime != null) return false;
        return unit != null ? unit.equals(that.unit) : that.unit == null;
    }

    @Override
    public int hashCode() {
        int result = startTime != null ? startTime.hashCode() : 0;
        result = 31 * result + (endTime != null ? endTime.hashCode() : 0);
        result = 31 * result + (unit != null ? unit.hashCode() : 0);
        return result;
    }

    @Override
    public String toString() {
        return "MetricsRequest{" +
                "startTime=" + startTime +
                ", endTime=" + endTime +
                ", unit=" + unit +
                '}';
    }
}
