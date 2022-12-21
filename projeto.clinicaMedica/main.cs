using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.clinicaMedica
{
    public class Program
    {
        static void Main(string[] args)
        {
            marcarConsulta consulta = new marcarConsulta("thiago", "cardiologista");
            Console.WriteLine(consulta.mensagem); 

        }

    }
}
