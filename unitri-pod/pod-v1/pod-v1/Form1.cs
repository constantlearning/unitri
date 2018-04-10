using pod_v1.sort.algoritmos;
using pod_v1.sort.entidade;
using pod_v1.sort.entity;
using pod_v1.sort.util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pod_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            FiltrarCandidatos filtrarCandidatos = new FiltrarCandidatos();
            List<Candidato> candidatos = new List<Candidato>();

            if (rbNotaAcima.Checked)
            {
                candidatoBindingSource.Clear();
                candidatos.Clear();
                double nota = Convert.ToDouble(txtNotaAcima.Text);
                candidatos = filtrarCandidatos.candidatosAcimaDaNota(nota);
            }

            if (rbNotaAbaixo.Checked)
            {
                candidatoBindingSource.Clear();
                candidatos.Clear();
                double nota = Convert.ToDouble(txtNotaAbaixo.Text);
                candidatos = filtrarCandidatos.candidatosAbaixoDaNota(nota);
            }

            if (rbIntervaloInscricao.Checked)
            {
                candidatoBindingSource.Clear();
                candidatos.Clear();
                long inicio = long.Parse(txtInvervaloInicio.Text);
                long final = long.Parse(txtInvervaloFinal.Text);
                candidatos = filtrarCandidatos.candidatosNoIntervaloDeInscricao(inicio, final);
            }

            candidatoBindingSource.DataSource = candidatos;
            lblTotal.Text = Convert.ToString(candidatos.Count);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<Candidato> candidatoList = null;

            try
            {
                candidatoList = (List<Candidato>)candidatoBindingSource.DataSource;
            }
            catch (Exception ex) { }

            if (candidatoList == null)
            {
                MessageBox.Show("Carregue os dados antes de ordenar.");
                return;
            }

            List<Candidato> resultadoOrdenado = new List<Candidato>();

            // Bubble Sort
            if (rbBubbleSort.Checked && rbNome.Checked)
            {
                resultadoOrdenado.Clear();
                BubbleSort bubbleSort = new BubbleSort(candidatoList, TIPO.NOME);
                resultadoOrdenado = bubbleSort.sort();
                lblTempo.Text = Convert.ToString(bubbleSort.StopWatch.Elapsed);
            }

            if (rbBubbleSort.Checked && rbInscricao.Checked)
            {
                resultadoOrdenado.Clear();
                BubbleSort bubbleSort = new BubbleSort(candidatoList, TIPO.MATRICULA);
                resultadoOrdenado = bubbleSort.sort();
                lblTempo.Text = Convert.ToString(bubbleSort.StopWatch.Elapsed);
            }

            if (rbBubbleSort.Checked && rbNota.Checked)
            {
                resultadoOrdenado.Clear();
                BubbleSort bubbleSort = new BubbleSort(candidatoList, TIPO.NOTA);
                resultadoOrdenado = bubbleSort.sort();
                lblTempo.Text = Convert.ToString(bubbleSort.StopWatch.Elapsed);
            }

            // Selection Sort
            if (rbSelectionSort.Checked && rbNome.Checked)
            {
                resultadoOrdenado.Clear();
                SelectionSort selectionSort = new SelectionSort(candidatoList, TIPO.NOME);
                resultadoOrdenado = selectionSort.sort();
                lblTempo.Text = Convert.ToString(selectionSort.StopWatch.Elapsed);
            }

            if (rbSelectionSort.Checked && rbInscricao.Checked)
            {
                resultadoOrdenado.Clear();
                SelectionSort selectionSort = new SelectionSort(candidatoList, TIPO.MATRICULA);
                resultadoOrdenado = selectionSort.sort();
                lblTempo.Text = Convert.ToString(selectionSort.StopWatch.Elapsed);
            }

            if (rbSelectionSort.Checked && rbNota.Checked)
            {
                resultadoOrdenado.Clear();
                SelectionSort selectionSort = new SelectionSort(candidatoList, TIPO.NOTA);
                resultadoOrdenado = selectionSort.sort();
                lblTempo.Text = Convert.ToString(selectionSort.StopWatch.Elapsed);
            }

            // Insertion Sort
            if (rbInsertionSort.Checked && rbNome.Checked)
            {
                resultadoOrdenado.Clear();
                InsertionSort insertionSort = new InsertionSort(candidatoList, TIPO.NOME);
                resultadoOrdenado = insertionSort.sort();
                lblTempo.Text = Convert.ToString(insertionSort.StopWatch.Elapsed);
            }

            if (rbInsertionSort.Checked && rbInscricao.Checked)
            {
                resultadoOrdenado.Clear();
                InsertionSort insertionSort = new InsertionSort(candidatoList, TIPO.MATRICULA);
                resultadoOrdenado = insertionSort.sort();
                lblTempo.Text = Convert.ToString(insertionSort.StopWatch.Elapsed);
            }

            if (rbInsertionSort.Checked && rbNota.Checked)
            {
                resultadoOrdenado.Clear();
                InsertionSort insertionSort = new InsertionSort(candidatoList, TIPO.NOTA);
                resultadoOrdenado = insertionSort.sort();
                lblTempo.Text = Convert.ToString(insertionSort.StopWatch.Elapsed);
            }

            // Merge Sort
            if (rbMergeSort.Checked && rbNome.Checked)
            {
                resultadoOrdenado.Clear();
                MergeSort mergeSort = new MergeSort(TIPO.NOME);
                resultadoOrdenado = mergeSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(mergeSort.StopWatch.Elapsed);
            }

            if (rbMergeSort.Checked && rbInscricao.Checked)
            {
                resultadoOrdenado.Clear();
                MergeSort mergeSort = new MergeSort(TIPO.MATRICULA);
                resultadoOrdenado = mergeSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(mergeSort.StopWatch.Elapsed);
            }

            if (rbMergeSort.Checked && rbNota.Checked)
            {
                resultadoOrdenado.Clear();
                MergeSort mergeSort = new MergeSort(TIPO.NOTA);
                resultadoOrdenado = mergeSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(mergeSort.StopWatch.Elapsed);

            }

            // Quick Sort
            if (rbQuickSort.Checked && rbNome.Checked)
            {
                resultadoOrdenado.Clear();
                QuickSort quickSort = new QuickSort(TIPO.NOME);
                resultadoOrdenado = quickSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(quickSort.StopWatch.Elapsed);
            }

            if (rbQuickSort.Checked && rbInscricao.Checked)
            {
                resultadoOrdenado.Clear();
                QuickSort quickSort = new QuickSort(TIPO.MATRICULA);
                resultadoOrdenado = quickSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(quickSort.StopWatch.Elapsed);
            }

            if (rbQuickSort.Checked && rbNota.Checked)
            {
                resultadoOrdenado.Clear();
                QuickSort quickSort = new QuickSort(TIPO.NOTA);
                resultadoOrdenado = quickSort.sort(candidatoList);
                lblTempo.Text = Convert.ToString(quickSort.StopWatch.Elapsed);
            }

            candidatoBindingSource.Clear();
            candidatoBindingSource.DataSource = resultadoOrdenado;
            lblTotal.Text = Convert.ToString(resultadoOrdenado.Count);
        }
    }
}
