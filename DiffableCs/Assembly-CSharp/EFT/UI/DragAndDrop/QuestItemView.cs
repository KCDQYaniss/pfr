namespace EFT.UI.DragAndDrop;

public sealed class QuestItemView : StaticGridItemView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IInventoryProfileInfo profile; //Field offset: 0x10
		public QuestItemView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <InitCompletableIcon>b__0() { }

	}

	[SerializeField]
	private GameObject _selectedQuestItemBorder; //Field offset: 0x2E0
	[SerializeField]
	private Image _completeIcon; //Field offset: 0x2E8

	public QuestItemView() { }

	public static QuestItemView Create(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	private void InitCompletableIcon(Item item, ItemController itemController) { }

	private QuestItemView NewQuestItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	private void OnCompletableItemStatusChange(MongoID itemTemplateId, bool completed) { }

	public void SetSelectedStatus(bool value) { }

}

