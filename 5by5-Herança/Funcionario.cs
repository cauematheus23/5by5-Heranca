using System.Security.Cryptography.X509Certificates;

public class Funcionario:Pessoa
 {
    public int codigo;
    public string cargo;

    public Funcionario()
    {
      
    }
    public void DefinirCodigo(int c)
    {
        this.codigo = c;
    }
    public void DefinirCargo(string cargo)
    {
        this.cargo = cargo;
    }
    public void ImprimirFuncionario()
    {
        ImprimirPessoa();
        Console.WriteLine("Codigo Funcionario: " + this.codigo);
        Console.WriteLine("Cargo Funcionario: " + this.cargo);
    }
}

