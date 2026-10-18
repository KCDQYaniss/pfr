namespace EFT;

public sealed class ItemRequirementsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Stash stashGrid; //Field offset: 0x10
		public ItemRequirementsPanel <>4__this; //Field offset: 0x18
		public Color goodColor; //Field offset: 0x20
		public Color badColor; //Field offset: 0x30
		public Action onAvailableChanged; //Field offset: 0x40

		public <>c__DisplayClass12_0() { }

		internal void <CreateItemsViews>b__0(ItemRequirements item, RequiredItem view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public ItemRequirements item; //Field offset: 0x10
		public ECurrencyType moneyType; //Field offset: 0x18
		public RequiredItem view; //Field offset: 0x20
		public <>c__DisplayClass12_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass12_1() { }

		internal bool <CreateItemsViews>b__4(Item x) { }

		internal bool <CreateItemsViews>g__Available|1() { }

		internal bool <CreateItemsViews>g__Available|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_2
	{
		public ItemIcon itemIcon; //Field offset: 0x10
		public <>c__DisplayClass12_1 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass12_2() { }

		internal void <CreateItemsViews>b__3() { }

	}

	[SerializeField]
	private RequiredItem _template; //Field offset: 0x70
	[SerializeField]
	private Sprite _rubSprite; //Field offset: 0x78
	[SerializeField]
	private Sprite _euroSprite; //Field offset: 0x80
	[SerializeField]
	private Sprite _dollarSprite; //Field offset: 0x88
	[SerializeField]
	private Sprite _gpSprite; //Field offset: 0x90
	[SerializeField]
	private HoverTooltipArea _tooltipArea; //Field offset: 0x98
	private bool _allAvailable; //Field offset: 0xA0
	private ViewList _views; //Field offset: 0xA8
	private readonly Dictionary _cachedItemSprites; //Field offset: 0xB0
	private readonly Dictionary _cachedItems; //Field offset: 0xB8

	public ItemRequirementsPanel() { }

	public void CreateItemsViews(Stash stashGrid, ItemRequirements[] requirements, Color goodColor, Color badColor, Action onAvailableChanged) { }

	private Sprite GetCurrencySprite(ECurrencyType currencyType) { }

	public void Show(Stash stashGrid, ItemRequirements[] requirements, Color goodColor, Color badColor, Action onAvailableChanged) { }

	public void UpdateView() { }

}

