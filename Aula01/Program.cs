// Comentário de uma linha

/*
    Comentário de 
    Múltiplas linhas
*/

// Declarando variável 

using Aula01;

int number;

// Atribuindo valor

number = 10;

Console.WriteLine(number);

// Declarando constante 

const int DAYS_IN_WEEK = 7;

// Imprimindo String concatenada

Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto
// Toda classe tem o seu construtor padrão implicito sem argumentos/parametros
// É possivel sobrescrever este método especificando argumentos 
// Todavia, se o fizermos, perdemos o original implicito e 
// precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine($"O enum de english é {enumEnglish}");
