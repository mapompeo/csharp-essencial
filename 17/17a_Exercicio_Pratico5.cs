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

// Criando o objeto com outro construtor
Carro astra = new Carro("Astra", "GM");
// Passagem de parâmetros por valor (não altera na memória)
double potenciaAumentada = astra.AumentarPotencia(110);
Console.WriteLine(potenciaAumentada);

int potenciaAumentadaPorReferencia = 110;
// Passagem de parâmetros por referência (altera diretamente na memória)
astra.AumentarPotencia(ref potenciaAumentadaPorReferencia);
Console.WriteLine(potenciaAumentadaPorReferencia);

Console.WriteLine("out");
astra.AumentarPotenciaVelocidade(potenciaAumentadaPorReferencia, out velocidade);
Console.WriteLine(potenciaAumentadaPorReferencia);
Console.WriteLine(velocidade);

// Parâmetro com argumentos opcionais
Carro carroComParametros = new Carro(modelo: "SUV", montadora: "Ford", marca: "EcoSport", ano: 2018, potencia: 120);

carroComParametros.ExibirInfo(modelo: "SUV", montadora: "Ford", marca: "EcoSport", potencia: 120);
// Os parâmetros opcionais são utilizados quando não declaramos os atributos no envio do método
carroComParametros.ExibirInfo(modelo: "SUV", montadora: "Ford", marca: "EcoSport", potencia: 120, ano: 2018);
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

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    // Sobrecarga de métodos: quando você tem mais de um método com mesmo nome mas passando atributos diferentes em cada um deles
    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }

    // Método com parâmetro out
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2000)
    {
        Console.WriteLine($"Modelo: {modelo}, Montadora {montadora}, Marca: {marca}, Potência: {potencia}, Ano: {ano}");
    }
}