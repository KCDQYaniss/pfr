namespace EFT.UI.Ragfair;

public sealed class ItemMarketPricesPanel : UIElement
{
	[SerializeField]
	private ClickableUIText _lowestLabel; //Field offset: 0x70
	[SerializeField]
	private ClickableUIText _averageLabel; //Field offset: 0x78
	[SerializeField]
	private ClickableUIText _maximumLabel; //Field offset: 0x80
	[SerializeField]
	private GameObject _loader; //Field offset: 0x88
	[SerializeField]
	private GameObject _pricesPanel; //Field offset: 0x90
	private RagFair _ragfair; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnPriceClick; //Field offset: 0xA0
	[CompilerGenerated]
	private float <Minimum>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <Average>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private float <Maximum>k__BackingField; //Field offset: 0xB0

	public event Action OnPriceClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private float Average
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float Maximum
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float Minimum
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public ItemMarketPricesPanel() { }

	[CompilerGenerated]
	private void <UpdatePrices>b__22_0(ItemMarketPrices result) { }

	[CompilerGenerated]
	private void <UpdatePrices>b__22_1(string _) { }

	[CompilerGenerated]
	private void <UpdatePrices>b__22_2(string _) { }

	[CompilerGenerated]
	private void <UpdatePrices>b__22_3(string _) { }

	[CompilerGenerated]
	public void add_OnPriceClick(Action value) { }

	private static string FormatValue(float value) { }

	[CompilerGenerated]
	public float get_Average() { }

	[CompilerGenerated]
	public float get_Maximum() { }

	[CompilerGenerated]
	public float get_Minimum() { }

	private void PriceClickInvoke(float value) { }

	[CompilerGenerated]
	public void remove_OnPriceClick(Action value) { }

	[CompilerGenerated]
	private void set_Average(float value) { }

	[CompilerGenerated]
	private void set_Maximum(float value) { }

	[CompilerGenerated]
	private void set_Minimum(float value) { }

	public void Show(RagFair ragfair) { }

	public void UpdatePrices(string templateId) { }

}

