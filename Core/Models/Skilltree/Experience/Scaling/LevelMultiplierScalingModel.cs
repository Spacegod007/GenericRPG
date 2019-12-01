namespace Core.Models.Skilltree.Experience.Scaling
{
	public class LevelMultiplierScalingModel : CustomScalingModel
	{
		private readonly decimal _multiplier;

		public LevelMultiplierScalingModel(long initial, decimal multiplier)
			: base(initial)
		{
			_multiplier = multiplier;
		}

		protected override long CalculateRequirement(int level) => (long) _multiplier * level * Initial;
	}
}
