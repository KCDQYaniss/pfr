namespace EFT.UI;

public sealed class PlayerQuestsWindow : Window
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__IsRegularQuest; //Field offset: 0x0
		public static Func <1>__IsDailyQuest; //Field offset: 0x8

	}

	[SerializeField]
	private UIAnimatedToggleSpawner _defaultQuestsToggleSpawner; //Field offset: 0xB8
	[SerializeField]
	private UIAnimatedToggleSpawner _dailyQuestsToggleSpawner; //Field offset: 0xC0
	[SerializeField]
	private TasksPanel _tasksPanel; //Field offset: 0xC8
	private Func _questsAdditionalFilter; //Field offset: 0xD0

	public PlayerQuestsWindow() { }

	[CompilerGenerated]
	private void <Awake>b__4_0(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__4_1(bool arg) { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	public DialogWindowContext Show(InventoryController inventoryController, IEftSession session, QuestController questController) { }

}

