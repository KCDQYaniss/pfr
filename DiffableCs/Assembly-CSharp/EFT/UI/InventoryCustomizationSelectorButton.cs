namespace EFT.UI;

public class InventoryCustomizationSelectorButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public InventoryCustomizationSelectorButton <>4__this; //Field offset: 0x10
		public ClothingIcon icon; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <UpdateValue>g__IconChangedHandler|0() { }

	}

	[SerializeField]
	private Image _background; //Field offset: 0x20
	[SerializeField]
	private Image _icon; //Field offset: 0x28
	[SerializeField]
	private Image _border; //Field offset: 0x30
	[SerializeField]
	private Color _backgroundActiveColor; //Field offset: 0x38
	[SerializeField]
	private Color _backgroundInactiveColor; //Field offset: 0x48
	[SerializeField]
	private Color _borderActiveColor; //Field offset: 0x58
	[SerializeField]
	private Color _borderInactiveColor; //Field offset: 0x68
	[CompilerGenerated]
	private CustomizationSuite <CustomizationSuite>k__BackingField; //Field offset: 0x78
	private TooltipController _tooltipController; //Field offset: 0x80
	private CompositeDisposable _dispose; //Field offset: 0x88
	private string _tooltipText; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnClick; //Field offset: 0x98

	public event Action OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private CustomizationSuite CustomizationSuite
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Sprite IconSprite
	{
		 get { } //Length: 30
	}

	public InventoryCustomizationSelectorButton() { }

	[CompilerGenerated]
	public void add_OnClick(Action value) { }

	public void Close() { }

	[CompilerGenerated]
	public CustomizationSuite get_CustomizationSuite() { }

	public Sprite get_IconSprite() { }

	public void Init(TooltipController tooltipController) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnClick(Action value) { }

	[CompilerGenerated]
	private void set_CustomizationSuite(CustomizationSuite value) { }

	public void SetSelected(bool selected) { }

	public void UpdateValue(CustomizationSuite suite, string tooltipText = null, Sprite sprite = null) { }

}

