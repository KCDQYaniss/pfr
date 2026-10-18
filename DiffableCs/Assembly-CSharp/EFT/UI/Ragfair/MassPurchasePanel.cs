namespace EFT.UI.Ragfair;

public sealed class MassPurchasePanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_1; //Field offset: 0x8
		public static Func <>9__8_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IExchangeable <Awake>b__8_1(KeyValuePair x) { }

		internal int <Awake>b__8_2(KeyValuePair x) { }

	}

	[SerializeField]
	private DefaultUIButton _purchaseButtonSpawner; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _totalPriceLabel; //Field offset: 0x78
	private Dictionary _includedItems; //Field offset: 0x80
	private Dictionary _itemsCache; //Field offset: 0x88
	private Dictionary _pickedItems; //Field offset: 0x90
	private RagFair _ragfair; //Field offset: 0x98
	private Action _onPurchaseButtonClicked; //Field offset: 0xA0
	private HashSet _selectedOffers; //Field offset: 0xA8

	public MassPurchasePanel() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	[CompilerGenerated]
	private bool <OnFilteredOffersChangedHandler>b__11_0(Offer offer) { }

	[CompilerGenerated]
	private void <Show>b__10_0() { }

	[CompilerGenerated]
	private void <Show>b__10_1() { }

	private void Awake() { }

	public virtual void Close() { }

	private bool IsAnyOfferAvailable(IEnumerable offers) { }

	private bool IsOfferAvailable(Offer offer) { }

	private void OnFilteredOffersChangedHandler(EViewListType viewType) { }

	private void OnOfferSelectedHandler(Offer offer, bool selected) { }

	private void OnSelectedOffersClearedHandler() { }

	private void PickOffers() { }

	public void Show(Dictionary includedItems, RagFair ragfair, Action onPurchaseButtonClicked) { }

	private void UpdateOffers() { }

}

