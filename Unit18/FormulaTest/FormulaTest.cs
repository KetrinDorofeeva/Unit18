using Xunit;
using Formula;

namespace FormulaTest
{
	public class FormulaTest
	{
		/* “естирование первой формулы */
		[Fact]
		public void FisrtFormulaTest()
        {
            // Arrage
            var formula = new Formulas(9, 0, -1, 9);
			double expected = formula.First;

			// Act
			formula.FirstFormula();
			var actual = formula.First;

			// Assert
			Assert.NotEqual(expected, actual);
        }

		/* “естирование второй формулы */
		[Fact]
		public void SecondFormulaTest()
		{
			// Arrage
			var formula = new Formulas(9, 0, 1, 0);
			double expected = formula.Second;

			// Act
			formula.SecondFormula();
			var actual = formula.Second;

			// Assert
			Assert.NotEqual(expected, actual);
		}

		/* “естирование третьей формулы */
		[Fact]
		public void ThirdFormulaTest()
		{
			// Arrage
			var formula = new Formulas(5, 2, 7, -1);
			double expected = formula.Third;

			// Act
			formula.ThirdFormula();
			var actual = formula.Third;

			// Assert
			Assert.NotEqual(expected, actual);
		}

		/* “естирование проверки на дробные числа */
		[Fact]
		public void IntegerNumbersTest()
		{
			// Arrage
			var formula = new Formulas(5.1, 2, 7, 1);
			var expected = formula;

			// Assert
			Assert.NotNull(expected);
		}

		/* “естирование проверки, что число B в третьей формуле не равно 0 */
		[Fact]
		public void NumberBZeroTest()
		{
			// Arrage
			var formula = new Formulas(5, 0, 7, 1);
			var expected = formula;

			// Assert
			Assert.NotNull(expected);
		}
	}
}