using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace Div 
{
	[Export(typeof(SimpleCalculator3.Interfaces.IOperation))]
	[ExportMetadata("Symbol", '/')]
	public class Div : SimpleCalculator3.Interfaces.IOperation
	{
		public int Operate(int left, int right)
		{
			if( right != 0)
				return left / right;

			unchecked
			{
				return (int)double.NaN;
			}
		}
	}
}
