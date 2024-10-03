public class Carro : Veiculo{
    
    private int numeroDePortas;
    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto!");
    }

    public Carro(string Marca, string Modelo, int Ano, int numeroDePortas) : base(Marca, Modelo, Ano)
    {
        this.numeroDePortas = numeroDePortas;
        
    }
}