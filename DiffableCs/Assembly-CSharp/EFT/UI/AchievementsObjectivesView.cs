namespace EFT.UI;

public sealed class AchievementsObjectivesView : ConditionalObjectivesView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ConditionCollection conditions; //Field offset: 0x10
		public AchievementsObjectivesView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal bool <CreateViewList>b__0(Condition x) { }

		internal void <CreateViewList>b__1(Condition condition, AchievementObjectiveView view) { }

	}

	[SerializeField]
	private AchievementObjectiveView _objectivePrefab; //Field offset: 0xA0
	private AchievementsController _achievementsController; //Field offset: 0xA8
	private Achievement _achievement; //Field offset: 0xB0

	public AchievementsObjectivesView() { }

	protected virtual void CreateViewList(ConditionCollection conditions) { }

	public virtual void Show(ConditionalController controller, ItemController itemController, ConditionCollection conditions, IConditional conditional) { }

}

