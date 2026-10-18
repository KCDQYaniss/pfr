namespace EFT.UI;

public sealed class ProfileDisplayOptionView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private Image _icon; //Field offset: 0x20
	[SerializeField]
	private GameObject _emptyIcon; //Field offset: 0x28
	[SerializeField]
	private Image _background; //Field offset: 0x30
	[SerializeField]
	private Image _border; //Field offset: 0x38
	[SerializeField]
	private Color _backgroundActiveColor; //Field offset: 0x40
	[SerializeField]
	private Color _backgroundInactiveColor; //Field offset: 0x50
	[SerializeField]
	private Color _borderActiveColor; //Field offset: 0x60
	[SerializeField]
	private Color _borderInactiveColor; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private HoverTooltipArea _tooltip; //Field offset: 0x88
	[CompilerGenerated]
	private ProfileDisplayOption <Option>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnClick; //Field offset: 0x98

	public event Action OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private ProfileDisplayOption Option
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ProfileDisplayOptionView() { }

	[CompilerGenerated]
	public void add_OnClick(Action value) { }

	public void Close() { }

	[CompilerGenerated]
	public ProfileDisplayOption get_Option() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnClick(Action value) { }

	[CompilerGenerated]
	private void set_Option(ProfileDisplayOption value) { }

	public void SetSelected(bool selected) { }

	public void Show(ProfileDisplayOption option, bool selected) { }

}

