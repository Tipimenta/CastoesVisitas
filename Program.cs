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


static void espaco(string var) {

    int espacos = (40 - var.Length) / 2; 
    if (espacos % 2 == 0)
    Console.Write("x");
    for (int i=1; i < espacos; i++){
        Console.Write(" ");
    }
    Console.Write(var);

    for (int i=1; i < espacos; i++){
        Console.Write(" ");
    }
    Console.Write("x");
}

static void espacoBranco(){
    Console.WriteLine("                                      ");
}



// Escreve o cartao de visita

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
espaco(nome);
espacoBranco();
espaco(profissao);
espacoBranco();
espaco(telefone);
espacoBranco();
espaco(descricao);
espacoBranco();
espaco(email);
espacoBranco();
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

