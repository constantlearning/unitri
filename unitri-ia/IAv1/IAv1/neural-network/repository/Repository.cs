using IAv1.neural_network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAv1.repository
{
    class Repository
    {
        private Double bias;
        private List<Neuron> neuronList;
        private List<Double> adjustableWeights;

        public Repository()
        {
            neuronList = new List<Neuron>();
            adjustableWeights = new List<Double>();
            // W1
            adjustableWeights.Add(0.0);
            // W2
            adjustableWeights.Add(0.0);
            // W3
            adjustableWeights.Add(0.0);
            // W4
            adjustableWeights.Add(0.0);
            // Bias Weight.
            adjustableWeights.Add(0.0);
        }

        public void setBias(double defaultBias)
        {
            this.bias = defaultBias;
        }

        public Double getBias()
        {
            return this.bias;
        }

        public Double getBiasWeight()
        {
            return this.adjustableWeights[4];
        }

        public void updateBiasWeight(double newBiasWeight)
        {
            this.adjustableWeights[4] = newBiasWeight;
        }

        public void addNeuron(Neuron neuron)
        {
            this.neuronList.Add(neuron);
        }

        public List<Neuron> getNeuronList()
        {
            return this.neuronList;
        }

        public List<Double> getWeights()
        {
            return this.adjustableWeights;
        }

        public Double getWeight(int indexOfWeight)
        {
            return this.adjustableWeights[indexOfWeight];
        }

        public void updateWeight(int indexOfWeight, Double newWeight)
        {
            this.adjustableWeights[indexOfWeight] = newWeight;
        }
    }
}
