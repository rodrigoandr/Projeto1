using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write(p.Nome +" "+ p.Sobrenome);

            Console.Read();
        }
    }
}
