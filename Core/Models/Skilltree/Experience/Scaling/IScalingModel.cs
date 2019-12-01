namespace Core.Models.Skilltree.Experience.Scaling
{
	public interface IScalingModel
	{
		long CalculateLevelRequirement(int level);
	}
}
