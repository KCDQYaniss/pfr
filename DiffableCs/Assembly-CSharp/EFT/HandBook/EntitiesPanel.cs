namespace EFT.HandBook;

public sealed class EntitiesPanel : UIElement
{
	[SerializeField]
	private HandbookItemPreview _itemPreview; //Field offset: 0x70
	[SerializeField]
	private Transform _entityListContent; //Field offset: 0x78
	[SerializeField]
	private EntityListElement _entityListElement; //Field offset: 0x80
	private BindableViewList _viewList; //Field offset: 0x88
	private readonly BindableList _filteredList; //Field offset: 0x90
	private BindableViewList _filteredViewList; //Field offset: 0x98
	private Handbook _handbook; //Field offset: 0xA0
	private List _questItems; //Field offset: 0xA8
	private EntityListElement _selectedNode; //Field offset: 0xB0
	private ItemUiContext _uiContext; //Field offset: 0xB8
	private Profile _profile; //Field offset: 0xC0

	public EntitiesPanel() { }

	[CompilerGenerated]
	private void <CreateBindableListView>b__13_0(HandbookNode item, EntityListElement view) { }

	public void AddToFilteredList(HandbookNode node) { }

	public void ChooseItem(string templateId) { }

	public void ClearEntity() { }

	public virtual void Close() { }

	private BindableViewList CreateBindableListView(IBindableList nodes) { }

	private void NodeChosen(HandbookNode node) { }

	public void Show(Handbook handbook, ItemUiContext itemUiContext, List questItems, Profile profile) { }

	public void ShowEntity(HandbookNode node) { }

}

