using System.ComponentModel;
using NewTalents;

namespace NewTalentsTest;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora(data);
        return calc;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestarSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(num1, num2);
        
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(2, 2, 0)]
    public void TestarSubtrair(int num1, int mum2,int resultado)
    {
        Calculadora calc = construirClasse();
        
        int resultadoCalculadora = calc.subtrair(num1, mum2);
        
        Assert.Equal(resultado,resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    public void TestarMultiplicar(int num1, int mum2,int resultado)
    {
        Calculadora calc = construirClasse();
        
        int resultadoCalculadora = calc.multiplicar(num1, mum2);
        
        Assert.Equal(resultado,resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(6, 2,3)]
    [InlineData(5, 5, 1)]
    public void TestarDividir(int num1, int num2,int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(num1, num2);
        
        Assert.Equal(resultado,resultadoCalculadora);
    }
    
    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
    }
    
    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(18, 2);
        calc.somar(8, 2);
        calc.somar(16, 9);
        calc.somar(10, 2);

        var lista = calc.historico();
        
        Assert.NotEmpty(calc.historico());
        
        Assert.Equal(3,lista.Count);
    }
}