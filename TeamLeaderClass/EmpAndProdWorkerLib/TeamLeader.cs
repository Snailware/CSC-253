using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	public class TeamLeader : ProductionWorker
	{
		public TeamLeader(string name, 
						  int number, 
						  int shiftNumber, 
						  double hourlyPayRate, 
						  double bonusAmount, 
						  int requiredTrainingHours, 
						  int completedTrainingHours)
			: base(name, number, shiftNumber, hourlyPayRate)
		{
			BonusAmount = bonusAmount;
			RequiredTrainingHours = requiredTrainingHours;
			CompletedTrainingHours = completedTrainingHours;
		}

		public double BonusAmount { get; set; }

		public int RequiredTrainingHours { get; set; }

		public int CompletedTrainingHours { get; set; }
	}
}
