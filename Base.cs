using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trabalho_as
{
    public abstract class Base // class abstrata  
    {
        public Base()
        {
            Id = ++Contador; // cada objeto criado sera gerado um id
        }
        private static int Contador = 0;
        public int Id { get; private set; }
    }
}
