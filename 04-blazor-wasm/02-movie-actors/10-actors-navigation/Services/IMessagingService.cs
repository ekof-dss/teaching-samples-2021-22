using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface IMessagingService
    {
        Task Add(string message);

        Task Clear();

        List<string> Get();

        event EventHandler<List<string>> OnMessagesChanged;
    }
}
