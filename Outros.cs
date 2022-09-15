/*cadastra clientes(nome, CPF, rg, data de nascimento, endereço).
cadastrarm funcionários(vendedores, gerente)(nome, cpf, rg, data de nascimento,
 endereço, salario)
cadastrar produtos(código, marca, descrição, valor unitário)
criar vendas (cliente, vendedor, lista de produtos)
permitir aumentar salário dos funcionários (regras diferentes para cada "tipo" de funcionário)
utilizar encapsulamento, polimorfismo, herança abstração;*/

namespace POO{

public class Outros{

    public void Outros(string[] args){

    Console.WriteLine("Para que serve o programa? \n É um simulador de compras e vendas.");
    Console.WriteLine("CLIENTES: nome, CPF, rg, data de nascimento, endereço.");
    Console.WriteLine("FUNCIONÁRIOS: vendedores e gerente (nome, cpf, rg, data de nascimento, endereço, salario).");
    Console.WriteLine("PRODUTOS: código, marca, descrição, valor.");
    Console.WriteLine("VENDAS: cliente, vendedor, lista de produtos.");
    Console.WriteLine("AUMENTO DE SALÁRIO: possibilita acréscimos no salário do funcionário.");
    Console.WriteLine("\n \n");
    Console.WriteLine("Programa feito por: Matheus e Taíssa.");
    Console.WriteLine("Motivo da criação do programa: Trabalho do curso de Desenvolvimento de Sistemas.");
    Console.WriteLine("Professor: Jean Fusinatto.");

}

}
    
}