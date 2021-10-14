using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    public class Titlu
    {
        public string motiv;
        public DateTime date;

        public Titlu(string titlu)
        {
            this.motiv = titlu;
            this.date = DateTime.Now;
        }
    }
}
