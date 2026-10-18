namespace EFT.InventoryLogic;

public sealed class QuestNoteLinkedItemContext : ItemContext
{
	private const string OFFER_REWARD_TOOLTIP = "UI/MainQuest/LinkedOfferTooltip{0}{1}"; //Field offset: 0x0
	private const string CRAFT_REWARD_TOOLTIP = "UI/MainQuest/LinkedCraftTooltip{0}{1}"; //Field offset: 0x0
	[CompilerGenerated]
	private LocalizedError <Error>k__BackingField; //Field offset: 0x68
	public readonly QuestNoteLinkItemBase LinkedItem; //Field offset: 0x70

	public virtual LocalizedError Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Tooltip
	{
		 get { } //Length: 695
	}

	public QuestNoteLinkedItemContext(QuestNoteLinkItemBase linkedItem) { }

	private QuestNoteLinkedItemContext(Item item, QuestNoteLinkedItemContext sourceContext) { }

	public virtual ItemContext CreateChild(Item item) { }

	[CompilerGenerated]
	public virtual LocalizedError get_Error() { }

	public string get_Tooltip() { }

	[CompilerGenerated]
	protected virtual void set_Error(LocalizedError value) { }

}

