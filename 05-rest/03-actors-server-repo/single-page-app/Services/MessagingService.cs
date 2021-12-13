using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public class MessagingService: IMessagingService
    {
        public List<string> Messages { get; set; }

        public MessagingService()
        {
            Messages = new List<string>();
        }
        public event EventHandler<List<string>> OnMessagesChanged; 

        public async Task Add(string message){
            Messages.Add(message);
            OnMessagesChanged?.Invoke(this, Messages);
            await Task.CompletedTask;
        }

        public async Task Clear(){
            Messages.Clear();
            OnMessagesChanged?.Invoke(this, Messages);
            await Task.CompletedTask;
        }

        public List<string> Get(){
            return Messages;
        }
        

    }
}
