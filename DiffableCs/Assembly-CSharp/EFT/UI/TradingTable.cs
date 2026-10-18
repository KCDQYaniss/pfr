namespace EFT.UI;

public class TradingTable : UIElement
{
	[SerializeField]
	private TradingTableGridView _tableGridView; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _clearTableButton; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	private Assortment _assortment; //Field offset: 0x88

	public TradingTable() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	private void Awake() { }

	public virtual void Close() { }

	public void Show(Assortment assortment, InventoryController inventoryController, ItemUiContext itemUiContext) { }

}

