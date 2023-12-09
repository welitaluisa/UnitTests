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
    double areaDoCubo = 6 * (lado * lado);
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

    public  static void Main()
    {
        // Metódo que chama as funções que calcula a área das figuras geométricas: Cubo, Paralelograma e Triângulo
        Console.WriteLine("A Área do Cubo com lado igual a 4 é: " + calcularAreaDoCubo(4));
        Console.WriteLine("A Área do Pararelograma com base igual a 4 e a altura igual a 2 é : " + calcularAreaDoParalelograma(4,2));
        Console.WriteLine("A Área do Triângulo com base iqual a 6 e a altura igual a 8 é: " + calcularAreaDoTriangulo(6,8));
    }
}
