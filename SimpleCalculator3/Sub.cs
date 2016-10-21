using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using static SimpleCalculator3.Interfaces;

namespace SimpleCalculator3
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '-')]
    class Subtract : IOperation
    {
        public int Operate(int left, int right)
        {
            return left - right;
        }
    }
}
