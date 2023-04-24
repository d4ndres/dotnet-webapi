using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Services
{
    public class HelloWordService : IHelloWorldService
    {
        public string getHelloWord()
        {
            return "Hello Word!";
        }
    }

    // Nos permite inyectar dependencias, expone el metodo que puede ser utilizado.
    // De no ser encontrado en la interfas no se podra encontrar
    public interface IHelloWorldService
    {
        string getHelloWord();
    }
}