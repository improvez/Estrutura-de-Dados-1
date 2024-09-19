using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilhasSenhas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Stack<InComingCall>? Calls { get; set; }
        public CallCenter() {
            Calls = new Stack<InComingCall>();
        }
        public void Call(int clientId) {
            Calls?.Push(
                new InComingCall(){
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
                }
            );
        }
        public InComingCall Answer(string consultant) {
            if(Calls!.Count > 0) {
                InComingCall call = Calls.Pop();
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
            return Calls?.Count > 0;
        }
    }
}