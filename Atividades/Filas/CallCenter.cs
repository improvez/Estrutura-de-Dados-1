using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<InComingCall>? Calls { get; set; }
        public CallCenter() {
            Calls = new Queue<InComingCall>();
        }

        // Método para abertura de chamados
        public void Call(int clientId) {
            Calls!.Enqueue(
                new InComingCall(){
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
                }
            );
        }

        public InComingCall Answer(string consultant) {
            // Validação: Verificar se tem atendimentos na fila
            if(Calls!.Count > 0) {
                InComingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;
                
                return call;
            }
            return null!;

        }

        public void End(InComingCall call) {
            call.EndTime = DateTime.Now;

        }

        public bool AreWaitingCalls() {
            return Calls!.Count > 0;
        }
    }
}