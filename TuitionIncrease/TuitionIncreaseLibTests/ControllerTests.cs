using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuitionIncreaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncreaseLib.Tests
{
	[TestClass()]
	public class ControllerTests
	{
		[TestMethod()]
		public void CalculateTuitionRateTest()
		{
			DataModel.StartingAmount = 0;
			DataModel.RateOfIncrease = 0;
			DataModel.NumberOfYears = 0;
			// arrange.

			Assert.ThrowsException<ArgumentException>(() => Controller.CalculateTuitionRate());
			// act & assert.
		}
	}
}