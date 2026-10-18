namespace EFT.UI;

public sealed class AchievementObjectiveView : ObjectiveView
{
	private Achievement _achievement; //Field offset: 0x118
	private AchievementsController _achievementsController; //Field offset: 0x120

	public AchievementObjectiveView() { }

	[CompilerGenerated]
	private void <CreateViewList>b__3_0(Condition item, AchievementObjectiveView view) { }

	protected virtual void CreateViewList() { }

	public void Show(Achievement achievement, Condition condition, AchievementsController achievementsController, ItemController controller, Sprite icon, bool childCondition = false) { }

}

