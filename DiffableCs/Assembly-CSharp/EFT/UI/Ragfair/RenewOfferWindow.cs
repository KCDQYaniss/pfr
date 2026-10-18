namespace EFT.UI.Ragfair;

public class RenewOfferWindow : UIElement
{
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _captionLabel; //Field offset: 0x78
	[SerializeField]
	private Button _closeButton; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _currentTimeLabel; //Field offset: 0x88
	[SerializeField]
	private CanvasGroup _minusButtonGroup; //Field offset: 0x90
	[SerializeField]
	private CanvasGroup _plusButtonGroup; //Field offset: 0x98
	[SerializeField]
	private Button _minusButton; //Field offset: 0xA0
	[SerializeField]
	private Button _plusButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _renewButton; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _taxPriceLabel; //Field offset: 0xB8
	[CompilerGenerated]
	private Offer <Offer>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private TimeSpan <CurrentTime>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private int <HoursCount>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <Prioritized>k__BackingField; //Field offset: 0xD4
	private Action _onRenew; //Field offset: 0xD8
	private RagFair _ragfair; //Field offset: 0xE0
	private InventoryController _inventoryController; //Field offset: 0xE8
	private TimeSpan _startingTime; //Field offset: 0xF0
	private TimeSpan _maxTime; //Field offset: 0xF8

	public private TimeSpan CurrentTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private TimeSpan CurrentTimeMinusHour
	{
		private get { } //Length: 255
	}

	private TimeSpan CurrentTimePlusHour
	{
		private get { } //Length: 253
	}

	public private int HoursCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Offer Offer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool Prioritized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public RenewOfferWindow() { }

	[CompilerGenerated]
	private void <Awake>b__35_0() { }

	[CompilerGenerated]
	private void <Awake>b__35_1() { }

	[CompilerGenerated]
	private void <Show>b__36_0() { }

	private void Awake() { }

	[CompilerGenerated]
	public TimeSpan get_CurrentTime() { }

	private TimeSpan get_CurrentTimeMinusHour() { }

	private TimeSpan get_CurrentTimePlusHour() { }

	[CompilerGenerated]
	public int get_HoursCount() { }

	[CompilerGenerated]
	public Offer get_Offer() { }

	[CompilerGenerated]
	public bool get_Prioritized() { }

	private void OnOfferRemoved(string offerId) { }

	private void Renew() { }

	[CompilerGenerated]
	private void set_CurrentTime(TimeSpan value) { }

	[CompilerGenerated]
	private void set_HoursCount(int value) { }

	[CompilerGenerated]
	private void set_Offer(Offer value) { }

	[CompilerGenerated]
	private void set_Prioritized(bool value) { }

	public void Show(InventoryController inventoryController, RagFair ragfair, Offer offer, TimeSpan time, Action onRenew) { }

	private void UpdateInfo() { }

}

