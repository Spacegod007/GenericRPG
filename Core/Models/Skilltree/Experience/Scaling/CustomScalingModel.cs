using System;

namespace Core.Models.Skilltree.Experience.Scaling
{
	public abstract class CustomScalingModel : IScalingModel
	{
		protected long Initial { get; }

		public CustomScalingModel(long initial)
		{
			Initial = initial;
		}

		public long CalculateLevelRequirement(int level)
		{
			if (level > 1)
			{
				return CalculateRequirement(level);
			}
			else if (level < 1)
			{
				throw new Exception("Level should always be at least 1 when a skill is unlocked/learned");
			}
			else
			{
				return Initial;
			}
		}

		protected abstract long CalculateRequirement(int level);
	}
}
