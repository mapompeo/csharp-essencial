// Criando os objetos
Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Exibir();
chevrolet.Acelerar(chevrolet.Marca);

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
ford.Exibir();
ford.Acelerar(ford.Marca);

// Criando o objeto com outro construtor
Carro meuCarro = new Carro("Onix", "GM");
meuCarro.Exibir();
double velocidade = meuCarro.VelocidadeMaxima(110);
Console.WriteLine(velocidade);

public class Carro
{
    // Atributos
    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Ano;
    public int Potencia;

    // Construtor
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    // Construtor
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    // Método
    public void Exibir()
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Ano);
        Console.WriteLine(Potencia);
    }

    // Método com argumento
    public void Acelerar(string marca)
    {
        Console.WriteLine("Acelerando o meu " + marca);
    }

    // Método com parâmetro
    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}