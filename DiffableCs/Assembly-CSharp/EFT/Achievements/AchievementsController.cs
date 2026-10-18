namespace EFT.Achievements;

public abstract class AchievementsController : ConditionalController
{
	[CompilerGenerated]
	private AchievementsBook <AchievementsBook>k__BackingField; //Field offset: 0x60

	public private AchievementsBook AchievementsBook
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AchievementsController(Profile profile, InventoryController inventoryController) { }

	protected virtual ConditionalBook CreateConditionalList() { }

	[CompilerGenerated]
	public AchievementsBook get_AchievementsBook() { }

	protected void OnAchievementUnlocked(string achId) { }

	protected virtual void OnConditionalStatusChangedEvent(Achievement achievement, bool notify) { }

	[CompilerGenerated]
	private void set_AchievementsBook(AchievementsBook value) { }

	protected override bool UnlockAchievementForced(string tpl) { }

}

