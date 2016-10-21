using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator3
{
	public class Interfaces
	{
		public interface ICalculator
		{
			String Calculate(String input);
		}

		public interface IOperation
		{
			int Operate(int left, int right);
		}

		public interface IOperationData
		{
			Char Symbol { get; }
		}

	}
}
