# Calculadora de Horas - Testes Unitários C#

## Desafio de Projeto
Desaio de projeto do bootcamp de C# da plataforma [DIO](www.dio.me)

## Premissas
O sistema possui dois projetos: Um tipo console e um do tipo testes com XUnit

**Classe Console**
| Classe          | Método                       | Objetivo                                                                                                                |
|---------------- |------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| DesafioTestes | Somar      | Recebe duas strings, transforma em horas e retorna uma string com o valor da soma                           |
| DesafioTestes | Subtrair | Recebe duas strings, transforma em horas e retorna uma string com o valor da subtração               |
| DesafioTestes | Multiplicacao      | Recebe uma string e um double, transforma a string em horas e retorna uma string com o valor da multiplicação dos valores |
| DesafioTestes | Divisao     | Recebe uma string e um double, transforma a string em horas e retorna uma string com o valor da divisão dos valores                                                |
| DesafioTestes | Historico      | Deixa apenas as últimas 3 operações na lista de histórico |

**Classe do tipo Testes**
| Classe           | Método                       | Objetivo                                                                                                                
|------------------|------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| TestDesafio | TestSomar | Recebe duas strings e testa o valor da soma                                                                           |
| TestDesafio | TestSubtrair              | Recebe duas strings e testa o valor da soma                 |
| TestDesafio | TestMultiplicar              |Recebe uma string e um double e testa o valor da multiplicação  |
| TestDesafio | TestDividir      | Recebe uma string e um double e testa o valor da divisão |
| TestDesafio | TestarHistorico      | Verifica se a lista não está vazia e se o número de elementos é igual ao número de métodos |
