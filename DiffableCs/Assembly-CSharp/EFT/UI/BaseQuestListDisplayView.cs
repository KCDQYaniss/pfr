namespace EFT.UI;

public abstract class BaseQuestListDisplayView : UIElement
{
	[CompilerGenerated]
	private QuestListDisplayContext <_context>k__BackingField; //Field offset: 0x70

	protected private QuestListDisplayContext _context
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BaseQuestListDisplayView() { }

	public abstract void ApplyFilters(IReadOnlyList excludeFilter, bool showCompleted) { }

	[CompilerGenerated]
	protected QuestListDisplayContext get__context() { }

	public abstract IEnumerable GetSelectableQuestViews() { }

	public override void RefreshStatuses() { }

	[CompilerGenerated]
	private void set__context(QuestListDisplayContext value) { }

	public override void Show(QuestListDisplayContext context) { }

	public override bool TryRevealFirstQuestView(ETierAccessoryType category, out QuestListItemView view) { }

	public override bool TryRevealQuestView(string questId, out QuestListItemView view) { }

}

