
// Array Unidimensional
int[] numbers;
numbers = new int[5];

// Atribuição de valor direta
// ai índice do vetor

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

// Declaração inicializada 
string[] names = ["Eu", "Tu", "Ele", "Nós", "Vós", "Eles"];

// Exemplo Vetor com os nomes dos meses
string[] months = new string[12];

for (int i = 1; i <= 12; i++) {
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    string name = firstDay.ToString("MMMM");
    
    months[i-1] = name;
} 

foreach(string m in months) {
    Console.WriteLine(m);
}

int[] numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] parLista = [];
int[] imparLista = [];
int counter = 0;
foreach(int num in numberList) {
    if (num % 2 == 0) {
        parLista[counter] = num;
    } else {
        imparLista[counter] = num;
    }
    counter++;
}

Console.WriteLine(parLista.Length);
Console.WriteLine(imparLista.Length);