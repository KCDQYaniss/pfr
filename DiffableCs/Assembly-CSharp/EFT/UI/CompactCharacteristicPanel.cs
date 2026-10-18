namespace EFT.UI;

public class CompactCharacteristicPanel : UIElement
{
	[SerializeField]
	protected Image Background; //Field offset: 0x70
	[SerializeField]
	protected Image Icon; //Field offset: 0x78
	[SerializeField]
	protected TextMeshProUGUI NameText; //Field offset: 0x80
	[SerializeField]
	protected TextMeshProUGUI ValueText; //Field offset: 0x88
	[SerializeField]
	protected Color _increasingColor; //Field offset: 0x90
	[SerializeField]
	protected Color _decreasingColor; //Field offset: 0xA0
	protected SimpleTooltip Tooltip; //Field offset: 0xB0
	protected ItemAttribute ItemAttribute; //Field offset: 0xB8
	protected ItemAttribute CompareItemAttribute; //Field offset: 0xC0
	protected int PeakDurability; //Field offset: 0xC8
	protected bool Examined; //Field offset: 0xCC
	[CompilerGenerated]
	private float <TextWidth>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private EventHandler OnTextWidthCalculated; //Field offset: 0xD8
	private string _dataForTooltip; //Field offset: 0xE0
	private UIParent _compareAttributeSubscription; //Field offset: 0xE8

	public event EventHandler OnTextWidthCalculated
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private float TextWidth
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public CompactCharacteristicPanel() { }

	[CompilerGenerated]
	private void <Awake>b__20_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__20_1(PointerEventData arg) { }

	[CompilerGenerated]
	private void <CompareWith>b__23_0() { }

	[CompilerGenerated]
	private void <Show>b__22_0() { }

	[CompilerGenerated]
	public void add_OnTextWidthCalculated(EventHandler value) { }

	protected override void Awake() { }

	private void CalculateTextWidth() { }

	public override void CompareWith(ItemAttribute attribute) { }

	[CompilerGenerated]
	public float get_TextWidth() { }

	protected override void OnDisable() { }

	[CompilerGenerated]
	public void remove_OnTextWidthCalculated(EventHandler value) { }

	[CompilerGenerated]
	private void set_TextWidth(float value) { }

	public override void SetValues() { }

	public void Show(ItemAttribute itemAttribute, SimpleTooltip tooltip, bool examined = true, int peakDurability = 100) { }

}

