namespace Core.Models.Skilltree.Experience.Scaling
{
	public class AddingScalingModel : CustomScalingModel
	{
		private readonly long _add;

		public AddingScalingModel(long initial, long add)
			: base(initial)
		{
			_add = add;
		}

		protected override long CalculateRequirement(int level) => Initial + _add * level;
	}
}
