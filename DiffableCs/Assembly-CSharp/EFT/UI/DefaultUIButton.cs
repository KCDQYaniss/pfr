namespace EFT.UI;

[RequireComponent(typeof(TweenAnimatedButton))]
public sealed class DefaultUIButton : ButtonFeedback
{
	[SerializeField]
	private Sprite _iconSprite; //Field offset: 0xA8
	[SerializeField]
	private Sprite _iconIdleSprite; //Field offset: 0xB0
	[SerializeField]
	private string _text; //Field offset: 0xB8
	[SerializeField]
	private int _fontSize; //Field offset: 0xC0
	[SerializeField]
	private float _minWidth; //Field offset: 0xC4
	[SerializeField]
	private bool _useEllipsis; //Field offset: 0xC8
	[SerializeField]
	private string _enabledTooltip; //Field offset: 0xD0
	[SerializeField]
	private string _disabledTooltip; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _headerLabel; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _sizeLabel; //Field offset: 0xE8
	[SerializeField]
	private Image _iconImage; //Field offset: 0xF0
	[SerializeField]
	private Image _iconIdleImage; //Field offset: 0xF8
	[SerializeField]
	private GameObject _iconContainer; //Field offset: 0x100
	[HideInInspector]
	[SerializeField]
	private TweenAnimatedButton _button; //Field offset: 0x108
	[HideInInspector]
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x110
	[SerializeField]
	private bool _rawText; //Field offset: 0x118
	public readonly UnityEvent OnClick; //Field offset: 0x120
	public readonly UnityEvent OnMouseOver; //Field offset: 0x128
	public readonly UnityEvent OnMouseOut; //Field offset: 0x130
	private Action _localeUnsubscriber; //Field offset: 0x138

	public int HeaderSize
	{
		 get { } //Length: 7
	}

	public string HeaderText
	{
		 get { } //Length: 8
	}

	public virtual bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 63
	}

	public DefaultUIButton() { }

	[CompilerGenerated]
	private void <Awake>g__OnClickHandler|27_0() { }

	private void ApplyParameters() { }

	private void Awake() { }

	public int get_HeaderSize() { }

	public string get_HeaderText() { }

	public virtual bool get_Interactable() { }

	private void OnDisable() { }

	private void OnEnable() { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	public virtual void set_Interactable(bool value) { }

	private void SetDirty(Object unityObject) { }

	public void SetHeaderText(string text, int fontSize) { }

	public void SetHeaderText(string text) { }

	public void SetIcon(Sprite icon, Sprite iconIdle = null) { }

	public void SetRawText(string text, int fontSize) { }

	private void SetText(string text, int fontSize, bool rawText) { }

	private void SetTooltips(string enabledTooltip, string disabledTooltip) { }

	private void UpdateEllipsis() { }

	private void UpdateFontSize() { }

	private void UpdateIcon() { }

	private void UpdateMinWidth() { }

	private void UpdateSizeText() { }

	private void UpdateText() { }

}

