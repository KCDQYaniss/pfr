namespace EFT.HandBook;

public sealed class HandbookItemPreview : UIElement
{
	[SerializeField]
	private ItemSpecificationPanel _itemSpecificationPanel; //Field offset: 0x70
	private ItemUiContext _itemUiContext; //Field offset: 0x78

	public HandbookItemPreview() { }

	public void ChooseEntity(Item item) { }

	public void ClearEntity() { }

	public void Show(ItemUiContext itemUiContext) { }

}

