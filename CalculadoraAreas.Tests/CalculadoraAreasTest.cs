// 1 - Bibliotecas
using NUnit.Framework;
using UnitTests;

// 2 - namespace
namespace CalculadoraAreas.Tests;

// 3 . Classe
[TestFixture] // Marcação que a classe ira usar testes parametrizados

public class Tests
{
    //3.1 - Atributos

    // 3.2 - Funções e métodos
   // Função de Leitura de Dados a partir de um arquivo csv
public static IEnumerable<TestCaseData> getTestData(String operation)
{
    String caminhoMassa = @"C:\Iterasys\UnitTests\CalculadoraAreas.Tests\Fixtures\"; // caminho do arquivo csv
    switch(operation)
    {
        case "areaTriangulo":
            caminhoMassa += @"massaAreaTriangulo.csv";
            break;
        case "areaCubo":
            caminhoMassa += @"massaAreaCubo.csv";
            break;
        case "areaParalelograma":
            caminhoMassa += @"massaAreaParalelograma.csv";
            break;    

    }
    using (var leitor = new StreamReader(caminhoMassa))
    {
        // pular a primeira linha
        leitor.ReadLine();
        
        // Repete as ações até a condição for satisfeita 
        // Ate terminar ler o arquivo CSV 
        while (leitor.EndOfStream == false)
        {
            var linha = leitor.ReadLine(); // lendo uma linha
            var valores = linha.Split(","); // dividir em campos

            yield return new TestCaseData(float.Parse(valores[0]), float.Parse(valores[1]), float.Parse(valores[2]));
        }
    }
}

    [Test]
    public void testCalcularAreaDoCubo()
    {
        // Triple A = AAA
        // Configura
        // Dados de entrada
        double lado = 10;

        // Resultado esperado / saida
        double resultadoEsperado = 600;

        // Executa 
        double resultadoObtido =  CalcularAreas.calcularAreaDoCubo(lado);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    } 

    [Test]
    public void testCalcularAreaDoParalelograma()
    {
        // Triple A = AAA
        // Configura
        // Dados de entrada
        double baseParalelogramo = 10;
        double alturaParalelogramo = 15;

        // Resultado esperado / saida
        double resultadoEsperado = 150;

        // Executa 
        double resultadoObtido =  CalcularAreas.calcularAreaDoParalelograma(baseParalelogramo, alturaParalelogramo);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    }
    
    [Test]
    public void testcalcularAreaDoTriangulo()
    {
        // Triple A = AAA
        // Configura
        // Dados de entrada
        double baseTriangulo = 10;
        double alturaTriangulo = 15;

        // Resultado esperado / saida
        double resultadoEsperado = 75;

        // Executa 
        double resultadoObtido =  CalcularAreas.calcularAreaDoTriangulo(baseTriangulo, alturaTriangulo);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    }

    [Test]
    public void testCalcularAreaDoCuboNegativo()
    {
        // Triple A = AAA
        // Configura
        // Dados de entrada
        double lado = -10;

        // Resultado esperado / saida
        double resultadoEsperado = 0; // O tratamento de erro retornará 0

        // Executa 
        double resultadoObtido =  CalcularAreas.calcularAreaDoCubo(lado);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    } 

     // Configura
    [TestCase(10,10,100)] // Caso de teste positivo
    [TestCase(9,10,90)] // Caso de teste positivo
    [TestCase(5, -5, 0) ] // Caso de teste com altura negativa
    [TestCase(-7, 7, 0) ] // Caso de teste com base negativa
    [TestCase(-3, -4, 0)] // Caso de teste com base e altura negativas
    [TestCase(0, 0, 0)  ] // Caso de teste com base e altura iqual a zero
    public void testCalcularAreaDoParalelogramaTC(double baseParalelogramo, double alturaParalelogramo, double resultadoObtido)
    {
    
        // Executa 
        double resultadoEsperado =  CalcularAreas.calcularAreaDoParalelograma(baseParalelogramo, alturaParalelogramo);

        // Valida
        Assert.That(resultadoObtido, Is.EqualTo(resultadoEsperado));

    }

    // Teste Data Driven 
    // Configura
    [Test, TestCaseSource("getTestData", new object[] {"areaTriangulo"})]
    public void testcalcularAreaDoTrianguloDD(double baseTriangulo, double alturaTriangulo, double resultadoObtido)
    {      
        // Executa 
        double resultadoEsperado =  CalcularAreas.calcularAreaDoTriangulo(baseTriangulo, alturaTriangulo);

        // Valida
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    }
}