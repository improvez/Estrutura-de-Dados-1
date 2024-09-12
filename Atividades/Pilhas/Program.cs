 
// Basicamente as pilhas trabalham com uma estrutura LIFO -> Last In First Out
// Três método importante:
// Push() -> Insere um elemento no topo da pilha 
// Pop() -> Remove um elemento do topo e o retorna
// Peek() -> Retorna o elemento do topo sem removê-lo

// Invertendo as bolas 

Stack<char> caracteres = new Stack<char>();
Console.Write("Digite um nome: ");
string? nome = Console.ReadLine();

foreach (char c in nome) {
    caracteres.Push(c);
}

// desempilhando 

string invertido = string.Empty;
while (caracteres.Count > 0) {
    invertido += caracteres.Pop();
}

Console.WriteLine(invertido);
if (invertido.ToLower() == nome.ToLower()) {
    Console.WriteLine("É um palindromo!!");
}

// Atividade 2: Utilizando o conceito de pilha ( Stack<>) com os métodos Pop() e Push(), escreva um programa que leia uma entrada do usuário e identifique
// se a palavra informada é ou não um palindromo