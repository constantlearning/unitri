package com.example.demo.domain;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.text.DecimalFormat;

public class MM1QueueTest {

    private MM1Queue mm1Queue;

    @Before
    public void setUp() throws Exception {
        this.mm1Queue = new MM1Queue(300, 400, 60);
    }

    @Test
    public void rateOfArrival() {
        Double result = this.mm1Queue.getLambda();
        Assert.assertEquals(new Double(5.0), result);
    }

    @Test
    public void serviceRate() {
        Double result = this.mm1Queue.getMu();
        DecimalFormat df = new DecimalFormat("#.##");
        Assert.assertEquals("6.67", df.format(result));
    }

    @Test
    public void probabilyOfServerBeingBusy() {
        Double result = this.mm1Queue.probabilyOfServerBeingBusy();
        Assert.assertEquals(new Double(0.75), result);
    }
}