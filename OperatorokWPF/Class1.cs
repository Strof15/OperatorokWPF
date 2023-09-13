using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorokWPF
{
    internal class Operatorok
    {
        
        

            int operandus;
            string operatoroks;
            int operandus2;






            public Operatorok(string TxtSorok)
            {
                var mezo = TxtSorok.Split();
                this.operandus = int.Parse(mezo[0]);
                this.operatoroks = mezo[1];
                this.operandus2 = int.Parse(mezo[2]);

            }

            public Operatorok(int operandus, string operatorok, int operandus2)
            {
                this.operandus = operandus;
                this.operatoroks = operatorok;
                this.operandus2 = operandus2;
            }

            public int Operandus { get => operandus; set => operandus = value; }
            public string Operatoroks { get => operatoroks; set => operatoroks = value; }
            public int Operandus2 { get => operandus2; set => operandus2 = value; }
        }
    }

