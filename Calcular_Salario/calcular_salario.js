//Lê os valores de Endrada:
const valorSalario = parseFloat(gets());
const valorBeneficios = parseFloat(gets());

//Calcula o imposto através da função "calcularImpoto":
const valorImposto = calcularImposto(valorSalario);
//Calcula e imprime a Saída (com 2 casas decimais):
const saida = valorSalario - valorImposto + valorBeneficios;
print(saida.toFixed(2));

//Função útil para o calculo do imposto (baseado nas alíquotas).
function calcularImposto(salario) {
    var aliquota;
    if (salario >= 0 && salario <= 1100) {
        aliquota = 0.05;
    } else if (salario >= 1100 && salario <= 2500) {
        aliquota = 0.10;
    } else (salario > 2500)
        aliquota = 0.15;
        
    //TO-DO Criar as demais condições para as aliquotas de 10.00% e 15.00%.
    return aliquota * salario;
}
    