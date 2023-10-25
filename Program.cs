using System;

/*
Criar um programa para escrever uim cartão de visita. 
O programa deve mostrar o nome, profissão, Email, descrição e telefone.
*/
//Solicita as informações do cartão

Console.WriteLine("Qual o seu nome?");
string? nome = Console.ReadLine();

Console.WriteLine("Qual sua profissao?");
string? profissao = Console.ReadLine();

Console.WriteLine("Digite o seu telefone?");
string? telefone = Console.ReadLine();

Console.WriteLine("Digite uma breve descrição");
string? descricao = Console.ReadLine();

Console.WriteLine("Digite seu email");
string? email = Console.ReadLine();





static void Espaco(string? var) {

    int espacos = (40 - var.Length) / 2; 

    for (int i=1; i < espacos; i++){
        Console.WriteLine(" ");
}
}


// Escreve o cartao de visita

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
Console.WriteLine(Espaco(nome));
Console.WriteLine("x                                 x");
Console.WriteLine("x     "+ profissao +"       x");
Console.WriteLine("x                                 x");
Console.WriteLine("x         "+ telefone +"         x");
Console.WriteLine("x                                 x");
Console.WriteLine("x   "+ descricao +"      x");
Console.WriteLine("x                                 x");
Console.WriteLine("x   "+ email +"      x");
Console.WriteLine("x                                 x");
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); 