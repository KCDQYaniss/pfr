namespace EFT.UI.DragAndDrop;

public sealed class QuestItemViewPanel : UIElement
{
	private enum EPanelViewType
	{
		None = 0,
		Quest = 1,
		QuestFoundInRaid = 2,
		FoundInRaid = 3,
	}

	private const string FOUND_IN_RAID_DESCRIPTION = "Item found in raid"; //Field offset: 0x0
	private const string QUEST_ITEM = "QUEST ITEM"; //Field offset: 0x0
	private const string RELATED_QUEST_ITEM_DESCRIPTION = "Item is related to an active {0} quest"; //Field offset: 0x0
	private const string ITEM_FITS_QUEST_DESCRIPTION = "Item fits the active {0} quest requirements"; //Field offset: 0x0
	private const string FOUND_QUEST_ITEM_DESCRIPTION = "Item that has been found in raid for the {0} quest"; //Field offset: 0x0
	[SerializeField]
	private Image _questIconImage; //Field offset: 0x70
	[SerializeField]
	private Sprite _questItemSprite; //Field offset: 0x78
	[SerializeField]
	private Sprite _foundInRaidSprite; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _questItemLabel; //Field offset: 0x88
	[CanBeNull]
	private SimpleTooltip _tooltip; //Field offset: 0x90
	private string _tooltipDescription; //Field offset: 0x98
	private Quest _tooltipQuest; //Field offset: 0xA0
	private string _tooltipText; //Field offset: 0xA8
	private bool _tooltipShown; //Field offset: 0xB0
	private Action _showItemTooltip; //Field offset: 0xB8

	public QuestItemViewPanel() { }

	[CompilerGenerated]
	private void <Awake>b__16_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__16_1(PointerEventData arg) { }

	private void Awake() { }

	public virtual void Close() { }

	private void CloseTooltip() { }

	private string GetTooltipText() { }

	private void OnDisable() { }

	private EPanelViewType PanelType(QuestController questController, Item item) { }

	public void Show(QuestController questController, Item item, SimpleTooltip tooltip, Action showItemTooltip = null) { }

}

