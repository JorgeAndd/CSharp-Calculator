using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    static class Calculator
    {
        private static float memory = 0;
        private static bool isMemoryEmpty = true;
        private enum Op { PLUS, MINUS, TIMES, DIV, RESULT }
        private static Op lastOp;

        public static float Operate(float number, string operation)
        {
            if(isMemoryEmpty)
            {
                memory = number;
                isMemoryEmpty = false;
                setLastOp(operation);

                return memory;
            }

            switch(lastOp)
            {
                case Op.PLUS:
                    memory += number;
                    break;
                case Op.MINUS:
                    memory -= number;
                    break;
                case Op.TIMES:
                    memory *= number;
                    break;
                case Op.DIV:
                    memory /= number;
                    break;
            }

            setLastOp(operation);
            return memory;

        }

        public static void setLastOp(string operation)
        {
            switch(operation)
            {
                case "plus":
                    lastOp = Op.PLUS;
                    return;
                case "minus":
                    lastOp = Op.MINUS;
                    return;
                case "times":
                    lastOp = Op.TIMES;
                    return;
                case "div":
                    lastOp = Op.DIV;
                    return;
            }
        }

        public static float Result(float number)
        {
            if (isMemoryEmpty)
                return 0;

            switch (lastOp)
            {
                case Op.PLUS:
                    memory += number;
                    break;
                case Op.MINUS:
                    memory -= number;
                    break;
                case Op.TIMES:
                    memory *= number;
                    break;
                case Op.DIV:
                    memory /= number;
                    break;
                case Op.RESULT:
                    break;
            }

            //isMemoryEmpty = true;
            return memory;
        }

        public static void Clear()
        {
            memory = 0;
            isMemoryEmpty = true;
        }
    }
}
