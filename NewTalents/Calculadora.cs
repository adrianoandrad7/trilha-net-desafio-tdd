namespace NewTalents;

public class Calculadora
{
    private List<string> _listaHistorico;
    private string data;
    public Calculadora(string data)
    {
        _listaHistorico= new List<string>();
        this.data = data;
    }
    public int somar(int num1, int num2)
    {
        int res = num1 + num2;
        _listaHistorico.Insert(0,"Res:" + res + " - data:" + data);
        return res;
    }
    
    public int subtrair(int num1, int num2)
    {
        int res = num1 - num2;
        _listaHistorico.Insert(0, "Res:" + res + " - data:" + data);
        return res;
    }
    
    public int multiplicar(int num1, int num2)
    {
        int res = num1 * num2;
        _listaHistorico.Insert(0,"Res:" + res + " - data:" + data );
        return res;
    }
    
    public int dividir(int num1, int num2)
    {
        int res = num1 / num2;
        _listaHistorico.Insert(0,"Res:" + res + " - data:" + data );
        return res;
    }
    
    public List<string> historico()
    {
        _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
        return _listaHistorico;
    }
}