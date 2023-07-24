namespace NomeDoProjeto;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// Os 4 pilares da POO
// A bstração
public class Caneta
{
    public string Cor ;
    // Para números quebrados
    // para números com virgula double
    public double Carga;
    //Bool para verdadeiro ou falso
    // Ou 0 ou 1
    public bool Tampada;
}

public class Cachorro
{
    // atributos são as caracteristicas,propriedades da classe
    // modificador de acesso public, private, protected
    // tipo de dado int,double,string,bool
    // nome do atributo

    public string Raca;
    public string Nome;
    public string Idade;

    //Como criar um método
        // modificador de acesso public, private, protected
        // tipo de retorno do método void, int, double, string, bool
        // nome do método
        // parênteses parâmetros de entrada do método
    public void Latir()
    {
        Console.WriteLine("Au au au");
    }
}

public class Aluno
{
    public int NumeroChamada;
    public double Nota;
    public string Nome; 
}

