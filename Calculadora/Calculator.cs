using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculator
    {
        private float memory = 0;
        private bool isMemoryEmpty = true;
        private enum Op { PLUS, MINUS, TIMES, DIV, RESULT }
        private Op lastOp = Op.RESULT;
        private float lastValue = 0;

        public float Operate(float number, string operation)
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

        public void setLastOp(string operation)
        {
            switch(operation)
            {
                case "+":
                    lastOp = Op.PLUS;
                    return;
                case "-":
                    lastOp = Op.MINUS;
                    return;
                case "x":
                    lastOp = Op.TIMES;
                    return;
                case "/":
                    lastOp = Op.DIV;
                    return;
            }
        }

        public float Result(float number)
        {
            //if (isMemoryEmpty)
            //    return 0;

            float result = memory;

            switch (lastOp)
            {
                case Op.PLUS:
                    result += number;
                    break;
                case Op.MINUS:
                    result -= number;
                    break;
                case Op.TIMES:
                    result *= number;
                    break;
                case Op.DIV:
                    result /= number;
                    break;
                case Op.RESULT:
                    return 0;
                default:
                    return 0;
            }

            isMemoryEmpty = true;
            return result;
        }

        public void Clear()
        {
            memory = 0;
            isMemoryEmpty = true;
        }
    }
}
