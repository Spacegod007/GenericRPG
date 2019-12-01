namespace Core.Models.Skilltree.Experience.Scaling
{
	public class ForLevelMultiplierScalingModel : CustomScalingModel
	{
		private readonly decimal _multiplier;

		public ForLevelMultiplierScalingModel(long initial, decimal multiplier)
			: base(initial)
		{
			_multiplier = multiplier;
		}
		
		protected override long CalculateRequirement(int level)
		{
			long requiredExperience = Initial;
			for (int i = 0; i < level; i++)
			{
				requiredExperience = (long) (requiredExperience * _multiplier);
			}
			return requiredExperience;
		}
	}
}
