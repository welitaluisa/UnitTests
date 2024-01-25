# Calculadora de Áreas
Este projeto é o primeiro desafio individual do curso de Formação em Teste de Software da Iterasys relacionado aos teste de Unidade em C#
Os testes contém: 
- Testes de unidade positivo para as três funções
- Teste de unidade negativo para a função que calcula a área do cubo
- Teste de unidade utilizando TestCase, positivo e negativo para a função que calcula a área do paralelogramo 
- Teste de unidade utilizando Data Driven que lê arquivo csv , para a função que calcula a área da pirâmide 

## Funcionalidades

O projeto inclui implementações para o cálculo de áreas do:

- Cubos
- Paralelogramas
- Triângulos

## Estrutura do Projeto

- `calcularAreas.cs`: Contém as funções para cálculo de áreas.
- `calcularAreasTests.cs`: Testes unitários utilizando NUnit.
- `Fixtures/`: Contém o arquivos CSV relacionado a área da pirâmide 

## Como Usar

1. **Requisitos:**
   - [.NET Core SDK](https://dotnet.microsoft.com/download) instalado.

2. **Clonar o Repositório:**
   ```bash
   git clone https://github.com/welitaluisa/UnitTests.git
   


## Comando para rodar os testes
- dotnet test -v n 
