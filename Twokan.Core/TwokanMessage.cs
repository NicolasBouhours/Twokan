using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Core
{
    public class TwokanMessage
    {
        public string UserName { get; set; }

        public string Message { get; set; }

        public string SerializeMessage()
        {
            return $"{UserName};{Message}";
        }

        public void DeserializeMessage(string serializedMessage)
        {
            string[] splited = serializedMessage.Split(';');
            UserName = splited[0];
            Message = splited[1];
        }

    }
}
