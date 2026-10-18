namespace EFT.UI.DragAndDrop;

public sealed class TradingItemContext : InventorySelectableItemContext
{
	private static readonly EItemInfoButton[] _restrictedInteractions; //Field offset: 0x0
	public readonly ETradingSide TradeSide; //Field offset: 0x90
	private readonly bool _restrictExternalActions; //Field offset: 0x94
	private ETradeMode _tradeMode; //Field offset: 0x98
	private readonly TradingItemContext _source; //Field offset: 0xA0
	private readonly Action _changeMode; //Field offset: 0xA8

	public ETradeMode TradeMode
	{
		 get { } //Length: 29
		 set { } //Length: 7
	}

	private static TradingItemContext() { }

	public TradingItemContext(Stash item, ETradeMode tradeMode, EItemViewType viewType, bool restrictExternalActions, Action changeMode) { }

	private TradingItemContext(Item item, TradingItemContext sourceContext) { }

	public void ChangeMode(ETradeMode mode) { }

	public virtual ItemContext CreateChild(Item item) { }

	public ETradeMode get_TradeMode() { }

	public virtual bool IsInteractionAllowed(EItemInfoButton button) { }

	public void set_TradeMode(ETradeMode value) { }

}

