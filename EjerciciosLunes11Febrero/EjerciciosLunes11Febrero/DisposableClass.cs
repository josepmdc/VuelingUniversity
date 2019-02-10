using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class DisposableClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Se ha ejecutado Dispose");
            Console.WriteLine();
        }
    }
}
