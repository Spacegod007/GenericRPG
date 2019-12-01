using Core.Models.Skilltree.Experience.Scaling;
using System;

namespace Core.Models.Skilltree
{
	public class Skill
	{
		public int Level { get; protected set; }

		public long LevelUpExperience { get; private set; }

		protected readonly IScalingModel _scalingModel;

		public long Experience { get; protected set; }

		public string Name { get; }

		public Skill(string name, IScalingModel scalingModel)
		{
			Name = name;
			_scalingModel = scalingModel;
		}

		protected void PrepareLevelUpExperience() => LevelUpExperience = _scalingModel.CalculateLevelRequirement(Level);
	}
}
