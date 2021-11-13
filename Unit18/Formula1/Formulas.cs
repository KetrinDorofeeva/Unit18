using System;

namespace Formula
{
    public class Formulas
    {
		public double A;
		public double B;
		public double C;
		public double X;

		public Formulas(double A, double B, double C, double X)
		{
			this.A = A;
			this.B = B;
			this.C = C;
			this.X = X;
		}

		public double First { get; private set; }
		public double Second { get; private set; }
		public double Third { get; private set; }

		/* Функция по первой формуле */
		public bool FirstFormula()
		{
			if (C < 0 && X != 0)
			{
				First = (-A * X) - C;
				return true;
			}
			else
			{
				return false;
			}
		}

		/* Функция по второй формуле */
		public bool SecondFormula()
		{
			if (C > 0 && X == 0)
			{
				Second = (X - A) / (-C);
				return true;
			}
			else
			{
				return false;
			}
		}

		/* Функция по третьей формуле */
		public bool ThirdFormula()
		{
			if ((C < 0 && X != 0) || (C > 0 && X == 0))
			{
				return false;
			}
			else
			{
				Third = (B * X) / (C - A);
				return true;
			}
		}

		/* Функция проверки, что числа не дробные */
		public bool IntegerNumbers()
		{
			if (A % 1 == 0 && B % 1 == 0 && C % 1 == 0 && X % 1 == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		/* Функция проверки, что число B не должно быть равным 0 */
		public bool NumberBZero()
		{
			if (B == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void Main(string[] args)
        {
			var fr = new Formulas(9, 0, -1, 1);

			var firstformula = fr.FirstFormula();
			var secondformula = fr.SecondFormula();
			var thirdformula = fr.ThirdFormula();
			var integernumbers = fr.IntegerNumbers();
			var bzero = fr.NumberBZero();

			var result1 = fr.First;
			var result2 = fr.Second;
			var result3 = fr.Third;

			if (firstformula)
            {
				if (integernumbers)
				{
					Console.WriteLine("Не должно быть дробных чисел!");
				} else
                {
					Console.WriteLine("Результат первой формулы: {0}", result1);
                }
			}

			if (secondformula)
			{
				if (integernumbers)
				{
					Console.WriteLine("Не должно быть дробных чисел!");
				}
				else
				{
					Console.WriteLine("Результат второй формулы: {0}", result2);
				}
			}

			if (thirdformula)
			{
				if (integernumbers)
				{
					Console.WriteLine("Не должно быть дробных чисел!");
				}
				else if (bzero)
                {
					Console.WriteLine("По третьей формуле B не должно быть равным 0!");
				}
				else
				{
					Console.WriteLine("Результат третьей формулы: {0}", result3);
				}
			}
		}
	}
}