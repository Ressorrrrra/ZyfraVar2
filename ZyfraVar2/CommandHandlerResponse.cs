using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2
{
    public class CommandHandlerResponse
    {
        public string Response;
        public bool Result; // для тестов

        public CommandHandlerResponse(string response, bool result)
        {
            Response = response;
            Result = result;
        }
    }
}
