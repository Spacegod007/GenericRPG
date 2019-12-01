using Core.Models.Skilltree.Experience.Scaling;

namespace Core.Models.Skilltree
{
	public class BasicSkill : Skill
	{
		public BasicSkill(string name, IScalingModel scalingModel)
			: base(name, scalingModel)
		{
			
		}

		public virtual void GrandExperience(long experience)
		{
			if (experience > 0)
			{
				Experience += experience;
				checkLevelUp();
			}
		}

		private bool isLevelUp() => Experience >= LevelUpExperience;

		private void levelUp()
		{
			Experience -= LevelUpExperience;
			Level++;
			PrepareLevelUpExperience();
		}

		private void checkLevelUp()
		{
			if (isLevelUp())
			{
				levelUp();
			}
		}
	}
}
