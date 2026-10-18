namespace EFT.UI;

public sealed class ResourceSelectionCell : ItemSelectionCell
{
	[SerializeField]
	private TextMeshProUGUI _details; //Field offset: 0xF8
	[SerializeField]
	private Color _defaultDetailsColor; //Field offset: 0x100
	private int _resourceCount; //Field offset: 0x110

	private ResourceComponent ResourceHolderItem
	{
		private get { } //Length: 76
	}

	public ResourceSelectionCell() { }

	private ResourceComponent get_ResourceHolderItem() { }

	protected virtual string GetDetails(Item item) { }

	private string GetDetailsText(ResourceComponent resourceHolder) { }

	public virtual void SetItem(Item item) { }

	public void Show(Item currentSelectedItem, IEnumerable filters, Func selectionChecker, Action selectionHandler) { }

	private void Update() { }

	private void UpdateDetails() { }

}

