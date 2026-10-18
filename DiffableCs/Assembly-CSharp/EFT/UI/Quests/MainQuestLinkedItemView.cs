namespace EFT.UI.Quests;

public sealed class MainQuestLinkedItemView : UIElement
{
	[SerializeField]
	private RectTransform _itemIconContainer; //Field offset: 0x70
	[SerializeField]
	private Dictionary _typeIcons; //Field offset: 0x78
	[SerializeField]
	private Image _typeIcon; //Field offset: 0x80
	[SerializeField]
	private GameObject _unreadMarker; //Field offset: 0x88
	private QuestNoteLinkItemBase _linkedItem; //Field offset: 0x90
	private Profile _profile; //Field offset: 0x98
	private IChaptersViewController _viewController; //Field offset: 0xA0
	private HoverReadTrigger _hoverReadTrigger; //Field offset: 0xA8

	public MainQuestLinkedItemView() { }

	[CompilerGenerated]
	private void <Show>b__8_0() { }

	private void CreateItemView() { }

	private void InitReadTrigger() { }

	private void ReadDataChangeHandler(MongoID changedId) { }

	private void ReadHandler() { }

	private void SetTypeIcon() { }

	public void Show(QuestNoteLinkItemBase linkedItem, IChaptersViewController viewController) { }

	private void UpdateReadStatus() { }

}

