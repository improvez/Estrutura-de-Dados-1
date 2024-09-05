using System.Collections;

// Utilizando a lista simples

ArrayList arrList  = new();

arrList.Add(5);
arrList.Add("Mauricio");

// É possivel adicionar um conjunto
// de valores de uma só vez

arrList.AddRange(new int[] {1,2,3});

// O método .Add() insere o valor
// ao final do vetor

arrList.Insert(1, 15);

// Já o metodo insert, me permite
// Incluir o valor desejado na posição
// especificada no primeiro parametro;

// Lendo valores da Lista

object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// percorrendo a Lista com foreach 

foreach(object obj in arrList) {
    // Console.Write($" | {obj}");
}

// Obtendo o tamanho total da lista
// Quantos elementos tem
int tamanho = arrList.Count;
Console.WriteLine(tamanho);

// obter a capacidade
// Quantos podem ser armazenados
int capacidade = arrList.Capacity;
Console.WriteLine(capacidade);

// Percorrendo no modo clássico

for(int i = 0; i < arrList.Count; i++) {
    Console.Write($" | {arrList[i]}");
} 

// Recursos importantes da Lista
// Verificar se um valor é contido na lista

bool contemNome = arrList.Contains("Mauricio");

if(!contemNome) {
    Console.WriteLine("Nome Mauricio não encontrado");
} else {
    Console.WriteLine("Nome encontrado");
}

// Para saber o indice que contem o valor buscado
// Neste caso se o valor existir na lista
// Ele retorna o indice (numero inteiro)
// Caso o valor não exista na lista, retorna -1

int indiceDoValor = arrList.IndexOf("Mauricio");

if(indiceDoValor >= 0) {
    Console.WriteLine($"Mauricio está em [{indiceDoValor}]");
} else {
    Console.WriteLine("É, realmente não tem.");
}

// É possivel também remover itens da lista

arrList.Remove("Mauricio"); // Remove pelo valor
arrList.RemoveAt(4); // Remove no indice
arrList.RemoveRange(0, 2); // O primeiro parametro é o indice e o segundo é quantas casas após o indice