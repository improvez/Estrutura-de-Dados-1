using System.Security.Cryptography;
using PilhasSenhas;

Random random = new Random();

CallCenter center = new();

center.Call(1111);
center.Call(1369);
center.Call(2468);
center.Call(1478);

while(center.AreWaitingCalls()) {
    Thread.Sleep(3000);
    InComingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss)}
         Senha: #{call.Id} 
         De: {call.ClientId} 
         Atendido por: {call.Consultant}"
    );
    Thread.Sleep(1000);
    center.End(call);
    Console.WriteLine(
        @$"Senha: {call.Id} 
        Encerrado às: {call.EndTime}"
    );
}