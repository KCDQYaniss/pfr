namespace EFT.UI.Map;

public sealed class ExtractionPointView : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private Image _background; //Field offset: 0x70
	[SerializeField]
	private Image _whiteIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _icon; //Field offset: 0x80
	[SerializeField]
	private GameObject _notGuaranteedIcon; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _nameLeft; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _nameRight; //Field offset: 0x98
	[SerializeField]
	private Image _textLeft; //Field offset: 0xA0
	[SerializeField]
	private Image _textRight; //Field offset: 0xA8
	[CompilerGenerated]
	private ExtractionPoint <ExtractionPoint>k__BackingField; //Field offset: 0xB0

	public private ExtractionPoint ExtractionPoint
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ExtractionPointView() { }

	[CompilerGenerated]
	public ExtractionPoint get_ExtractionPoint() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_ExtractionPoint(ExtractionPoint value) { }

	public void SetMainColor(Color32 color) { }

	public void Show(ExtractionPoint point, Action onDoubleClick) { }

	private void Update() { }

}

