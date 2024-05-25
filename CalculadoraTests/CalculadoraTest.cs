using CalculadoraConsole.Services;
using System;

namespace CalculadoraTests;

public class CalculadoraTest
{
    public Calculadora InstanciarCalculadora()
    {
        DateTime dataCompleta = DateTime.Now;

        string data = dataCompleta.ToString("dd/MM/yyyy HH:mm");

        Calculadora c = new Calculadora(data);

        return c;
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(5, 4, 9)]
    [InlineData(5, 5, 10)]
    public void RetornarSoma(int num1, int num2, int resultado)
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Act

        int resultadoOperacao = c.Somar(num1, num2);

        //Assert

        Assert.Equal(resultado, resultadoOperacao);
    }

    [Theory]
    [InlineData(2, 3, -1)]
    [InlineData(5, 4, 1)]
    [InlineData(5, 5, 0)]
    public void RetornarSubtracao(int num1, int num2, int resultado)
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Act

        int resultadoOperacao = c.Subtrair(num1, num2);

        //Assert

        Assert.Equal(resultado, resultadoOperacao);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(5, 4, 20)]
    [InlineData(5, 5, 25)]
    public void RetornarMultiplicacao(int num1, int num2, int resultado)
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Act

        int resultadoOperacao = c.Multiplicar(num1, num2);

        //Assert

        Assert.Equal(resultado, resultadoOperacao);
    }

    [Fact]
    public void VerificarDivisaoPorZero()
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Assert

        Assert.Throws<DivideByZeroException>(() => c.Dividir(3, 0));
    }

    [Theory]
    [InlineData(9, 3, 3)]
    [InlineData(18, 3, 6)]
    [InlineData(45, 5, 9)]
    public void RetornarDivisao(int num1, int num2, int resultado)
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Act

        int resultadoOperacao = c.Dividir(num1, num2);

        //Assert

        Assert.Equal(resultado, resultadoOperacao);
    }

    [Fact]
    public void VerificarPreenchimentoHistorico()
    {
        //Arrange

        Calculadora c = InstanciarCalculadora();

        //Act

        c.Somar(4, 6);
        c.Somar(7, 4);
        c.Somar(9, 5);
        c.Somar(6, 6);
        c.Somar(2, 8);

        var lista = c.Historico();

        //Assert

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}