// Criando um vetor multidimensional
// Com 5 linhas e 2 colunas 

int[,] numbers = new int[5,2];

// Criando um vetor tridimensional

int[,,] triNumbers = new int[5,4,3];

// Podemos inicializar os valores do vetor
// no momento de sua declaração

int[,] iniNumbers = new int[,] {
    {9,15, -9},
    {19,25, -90},
    {29,35, -91},
    {39,45, -92},
    {49,55, -93},
};

// Para acessar os valores contidos neste 
// tipo de variável

int valor = iniNumbers[0,1]; // Neste caso = 15

Console.WriteLine($"iniNumbers[0,1] == {valor}");

int high = 0;
// int counter = 0;
int position1 = 0;
int position2 = 0;

// foreach (int i in iniNumbers) {
//     counter += 1;
//     if (i > high) {
//         high = i;
//     }
// }

// Console.WriteLine($"na posição {counter / 3} o maior eh {high}");

for (int i = 0; i <= 4; i++ ) {
    for (int j = 0; j <= 2; j++ ) {
        if (iniNumbers[i,j] > high) {
            high = iniNumbers[i,j];
            position1 = i;
            position2 = j;
        }
    }
}

Console.WriteLine($"na posição [{position1}, {position2}] e o numero maior eh {high}");