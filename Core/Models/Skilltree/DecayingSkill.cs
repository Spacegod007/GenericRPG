using Core.Models.Skilltree.Experience.Scaling;

namespace Core.Models.Skilltree
{
	public class DecayingSkill : Skill
	{
		public DecayingSkill(string name, IScalingModel scalingModel) 
			: base(name, scalingModel)
		{

		}

		public void GrandExperience()
		{

		}
	}
}
