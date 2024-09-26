
using TarefaEmpregador;

List<Pessoa> pessoaList = new List<Pessoa>();
pessoaList.Add(new Pessoa() {
    Name = "Lucas",
    Phone = "49 99999",
});

bool connect = true;

Console.WriteLine("Informe seu número de telefone: ");

string? phoneNumber = Console.ReadLine();

while(connect) {

    Console.WriteLine("Escreva o código do produto desejado: ");

    int code = Convert.ToInt32(Console.ReadLine());

    switch (code) {
        case 0:
            Console.WriteLine("Produto 1");
            connect = false;
        break;
        default:
            Console.WriteLine("Produto não encontrado!!");
            connect = false;
        break;
    }
}