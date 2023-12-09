// 1-  Bibliotecas = Conjuntos de funções prontas

// 2 - Namespace  = Conjuto de classes
namespace UnitTests;

// 3 - Classe = Endidade que vamos criar ( nosso programa)
public class CalcularAreas
{
    
    // 3.1 - Atributos = Caracteristicas / Campos
    // 3.2 - Funções e Métodos 
public static double calcularAreaDoCubo(double lado)
{
    // Verifica se o lado é negativo antes de calcular a área
    if (lado <= 0)
    {
        Console.WriteLine("Erro: O lado do cubo não pode ser negativo ou Zero.");
        return 0; //indica um valor inválido
    }

    // Fórmula simples que calcula a área de um cubo => A = 6 * (lado²)
    double areaDoCubo = 6 * Math.Pow(lado, 2);
    return areaDoCubo;
}

public static double calcularAreaDoParalelograma(double baseParalelogramo, double alturaParalelogramo)
{
    // Verifica se a base ou a altura são negativas ou iguais a zero
    if (baseParalelogramo <= 0 && alturaParalelogramo <= 0)
    {
        Console.WriteLine("Erro: Base e altura do paralelograma devem ser maiores que zero.");
        return 0; //indicar um valor inválido
    }
    else if (baseParalelogramo <= 0)
        {
        Console.WriteLine("Erro: Base do paralelograma deve ser maior que zero.");
        return 0; //indicar um valor inválido
        }
    else if (alturaParalelogramo <= 0)
        {
        Console.WriteLine("Erro: Altura do paralelograma deve ser maior que zero.");
        return 0; //indicar um valor inválido
        }

    // Fórmula simples que calcula a área de um paralelograma => base * altura
        double areaDoParalelogramo = baseParalelogramo * alturaParalelogramo;
        return areaDoParalelogramo;
}
    public static double calcularAreaDoTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        {
        // Verifica se a base ou a altura são negativas
        if (baseTriangulo < 0 || alturaTriangulo < 0)
        {
            Console.WriteLine("Erro: A base e altura do triangulo devem ser maior que zero.");
            return 0; //indicar um valor inválido
        }

        // A fórmula para calcular a área de um triângulo é (base * altura) / 2
            return (baseTriangulo * alturaTriangulo) / 2.0;
        }
    }

public static void Main()
    {
        double ladoCubo = 4;
        double baseParalelograma = 4;
        double alturaParalelograma = 2;
        double baseTriangulo = 6;
        double alturaTriangulo = 8;

        Console.WriteLine($"A Área do Cubo com lado igual a {ladoCubo} é: {calcularAreaDoCubo(ladoCubo)} m²");
        Console.WriteLine($"A Área do Pararelograma com base igual a {baseParalelograma} e a altura igual a {alturaParalelograma} é: {calcularAreaDoParalelograma(baseParalelograma, alturaParalelograma)} m²");
        Console.WriteLine($"A Área do Triângulo com base igual a {baseTriangulo} e a altura igual a {alturaTriangulo} é: {calcularAreaDoTriangulo(baseTriangulo, alturaTriangulo)} m²");
    }
}
