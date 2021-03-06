﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace ExtendedOperations
{
	[Export(typeof(SimpleCalculator3.Interfaces.IOperation))]
	[ExportMetadata("Symbol", '*')]
	public class Mul : SimpleCalculator3.Interfaces.IOperation
	{
		public int Operate(int left, int right)
		{
			return left * right;
		}
	}
}
