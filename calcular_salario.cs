using System;

public class Desafio
{
    public static void Main()
    {
        //Lê os valodres de Endrada:
        float valorSalario = float.Parse(Console.ReadLine());
        float valorBeneficios = float.Parse(Console.ReadLine());

        float valorImposto = 0;
        if (valrSalario >= 0 && valorSalario <= 1100)
        {
            //Atribui a aliquota de 5% mediante o salário:
            valorImposto = 0.05f * valorSalario;
        }
        else if (valorSalario >= 1100.01 && valorSalario <= 2500.00)
        {
            valorImposto = 0.10F * valorSalario;
        }
        else (valorSalario >= 2500.00)
            {
                valorImposto = 0.15F * valorSalario;
        }
        //To-do Criar as demais condições para as aliquotas de 10.00% e 15.00%.

        //Calcula e imprime a Saída (com 2 casas decimais):
        float saida = valorSalario - valorImposto + valorBeneficios;
        Console.WriteLine(saida.ToString("0.00"));
    }
}
    