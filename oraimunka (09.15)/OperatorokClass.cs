using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorokwpf
{
    internal class OperatorokClass
    {
        int operandusA;
        string operatorjel;
        int operandusB;

        public OperatorokClass(string TxtSorok)
        {
            var mezo = TxtSorok.Split();
            this.operandusA = int.Parse(mezo[0]);
            this.operatorjel = mezo[1];
            this.operandusB = int.Parse(mezo[2]);

        }

        public OperatorokClass(int operandus, string operatorok, int operandus2)
        {
            this.operandusA = operandus;
            this.operatorjel = operatorok;
            this.operandusB = operandus2;
        }

        public int OperandusA { get => operandusA; set => operandusA = value; }
        public string Operatorjel { get => operatorjel; set => operatorjel = value; }
        public int OperandusB { get => operandusB; set => operandusB = value; }
    }
}

