
package com.example.aulasspring.model;


public class CalcModel {

    private double valor1;
    private double valor2;
    private double resultado;
    private String operacao;

    public double getValor1() {
        return valor1;
    }

    public void setValor1(double valor1) {
        this.valor1 = valor1;
    }

    public double getValor2() {
        return valor2;
    }

    public void setValor2(double valor2) {
        this.valor2 = valor2;
    }

    public double getResultado() {
        return resultado;
    }

    public void setResultado(double resultado) {
        this.resultado = resultado;
    }

    public String getOperacao() {
        return operacao;
    }

    public void setOperacao(String operacao) {
        this.operacao = operacao;
    }

    public void calcula() {
        switch (operacao) {
            case "soma":
                resultado = valor1 + valor2;
                break;

            case "subt":
                resultado = valor1 - valor2;
                break;

            case "mult":
                resultado = valor1 * valor2;
                break;

            case "divi":
                resultado = valor1 / valor2;
                break;
        }
    }

}
