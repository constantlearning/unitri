using IAv1.repository;
using System;
using System.Collections.Generic;

namespace IAv1.neural_network
{
    class Network
    {
        private Repository repository;

        public List<Double> getAdjustedWeights()
        {
            return repository.getWeights();
        }

        public Network(double defaultBias)
        {
            repository = new Repository();
            this.repository.setBias(defaultBias);
        }

        public void addInput(double x1, double x2, double x3, double x4, double y)
        {
            repository.addNeuron(
                    new Neuron(x1, x2, x3, x4, y)
            );
        }

        public double calculate(double x1, double x2, double x3, double x4)
        {
            Double result;

            result = (this.repository.getBias() * this.repository.getBiasWeight())
                    + (this.repository.getWeight(0) * x1)
                    + (this.repository.getWeight(1) * x2)
                    + (this.repository.getWeight(2) * x3)
                    + (this.repository.getWeight(3) * x4);

            return activationFunction(result);

        }

        public double calculate(Neuron neuron)
        {
            Double result;

            result = (this.repository.getBias() * this.repository.getBiasWeight())
                    + (this.repository.getWeight(0) * neuron.getX1())
                    + (this.repository.getWeight(1) * neuron.getX2())
                    + (this.repository.getWeight(2) * neuron.getX3())
                    + (this.repository.getWeight(3) * neuron.getX4());

            return activationFunction(result);

        }

        private double activationFunction(Double result)
        {

            if (result >= -0.2 && result <= 0.2)
            {
                return 0;
            }

            if (result > 0.2)
            {
                return 1;
            }

            return -1;
        }

        public void trainNetwork()
        {

            List<Neuron> neuronList = repository.getNeuronList();

            Int32 ciclos = 0;

            Int32 errors;
            do
            {
                errors = 0;
                foreach (Neuron neuron in neuronList)
                {

                    Double saidaErro = calculate(neuron) - neuron.getExpectedOut();

                    ciclos++;

                    if (saidaErro != 0)
                    {
                        // Calculating Delta W for input.
                        neuron.setDeltaw1(neuron.getX1() * neuron.getExpectedOut());
                        neuron.setDeltaw2(neuron.getX2() * neuron.getExpectedOut());
                        neuron.setDeltaw3(neuron.getX3() * neuron.getExpectedOut());
                        neuron.setDeltaw4(neuron.getX4() * neuron.getExpectedOut());

                        // Calculationg Delta W for bias.
                        Double deltaBias = repository.getBias() * neuron.getExpectedOut();

                        // Updating "Final" Weights
                        repository.updateWeight(0, repository.getWeight(0) + neuron.getDeltaw1());
                        repository.updateWeight(1, repository.getWeight(1) + neuron.getDeltaw2());
                        repository.updateWeight(2, repository.getWeight(2) + neuron.getDeltaw3());
                        repository.updateWeight(3, repository.getWeight(3) + neuron.getDeltaw4());
                        repository.updateBiasWeight(repository.getBiasWeight() + deltaBias);

                        errors++;
                    }
                }
            }
            while (errors > 0);


        }
    }
}
