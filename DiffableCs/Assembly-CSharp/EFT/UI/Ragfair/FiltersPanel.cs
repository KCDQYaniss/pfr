namespace EFT.UI.Ragfair;

public class FiltersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public FiltersPanel <>4__this; //Field offset: 0x10
		public RagfairFilterButton button; //Field offset: 0x18
		public ESortType sortType; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal void <InitButton>b__0(RagfairFilterButton _) { }

	}

	[SerializeField]
	private Toggle _checkBox; //Field offset: 0x70
	[SerializeField]
	private RagfairFilterButton _barterButton; //Field offset: 0x78
	[SerializeField]
	private RagfairFilterButton _ratingButton; //Field offset: 0x80
	[SerializeField]
	private RagfairFilterButton _offerItemButton; //Field offset: 0x88
	[SerializeField]
	private RagfairFilterButton _priceButton; //Field offset: 0x90
	[SerializeField]
	private RagfairFilterButton _expirationButton; //Field offset: 0x98
	[CompilerGenerated]
	private bool <Ascending>k__BackingField; //Field offset: 0xA0
	private readonly List _buttons; //Field offset: 0xA8
	private RagFair _ragfair; //Field offset: 0xB0
	private RagfairFilterButton _previousButton; //Field offset: 0xB8
	private bool _ignoreToggle; //Field offset: 0xC0

	private RagfairFilterButton ActiveFilterButton
	{
		private get { } //Length: 208
	}

	private bool Ascending
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public FiltersPanel() { }

	[CompilerGenerated]
	private void <Show>b__16_0() { }

	[CompilerGenerated]
	private void <Show>b__16_1() { }

	private void CheckboxClickHandler(bool isOn) { }

	public virtual void Close() { }

	private RagfairFilterButton get_ActiveFilterButton() { }

	[CompilerGenerated]
	private bool get_Ascending() { }

	private void InitButton(RagfairFilterButton button, ESortType sortType) { }

	private void OfferSelectionChangeHandler(Offer _, bool __) { }

	private void OnButtonClick(RagfairFilterButton button, ESortType sortType) { }

	private void OnFilterRuleChangedHandler(bool finished) { }

	[CompilerGenerated]
	private void set_Ascending(bool value) { }

	public void Show(RagFair ragfair, EViewListType type) { }

	private void UpdateVisualStateButtons(RagfairFilterButton currentButton) { }

}

