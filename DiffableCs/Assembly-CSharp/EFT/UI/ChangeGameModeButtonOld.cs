namespace EFT.UI;

public sealed class ChangeGameModeButtonOld : ButtonFeedback
{
	private class ButtonData
	{
		[Header("Colors")]
		public Color IdleTextColor; //Field offset: 0x10
		public Color HoverTextColor; //Field offset: 0x20
		[Header("Sprites")]
		public Sprite BgIdle; //Field offset: 0x30
		public Sprite BgHover; //Field offset: 0x38

		public ButtonData() { }

	}

	private const string TITLE_TEXT_KEY = "ChangeGameModeButton/ChangeProfile"; //Field offset: 0x0
	private const string DESCRIPTION_TEXT_KEY = "ChangeGameModeButton/Current{0}"; //Field offset: 0x0
	[Header("Title")]
	[SerializeField]
	private TextMeshProUGUI _buttonLabel; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _buttonLabelCanvasGroup; //Field offset: 0xB0
	[Header("Description")]
	[SerializeField]
	private TextMeshProUGUI _buttonDescription; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _buttonDescriptionCanvasGroup; //Field offset: 0xC0
	[SerializeField]
	private Image _buttonDescriptionIcon; //Field offset: 0xC8
	[Header("Backgrounds")]
	[SerializeField]
	private Image _backgroundIdle; //Field offset: 0xD0
	[SerializeField]
	private Image _backgroundHovered; //Field offset: 0xD8
	[Header("PMC")]
	[SerializeField]
	private SpriteAnimationPlayer _spriteAnimationPlayer; //Field offset: 0xE0
	[SerializeField]
	private Image _pmcImage; //Field offset: 0xE8
	[SerializeField]
	private Color _pmcColor; //Field offset: 0xF0
	[Header("State Data")]
	[SerializeField]
	private readonly Dictionary _stateData; //Field offset: 0x100
	private Tween _imageTween; //Field offset: 0x108
	private Tween _labelColorTween; //Field offset: 0x110
	private Tween _descriptionColorTween; //Field offset: 0x118
	private Tween _iconColorTween; //Field offset: 0x120
	private Tween _descriptionFadeTween; //Field offset: 0x128
	private ButtonData _currentButtonData; //Field offset: 0x130
	private bool _hasVisualState; //Field offset: 0x138
	private readonly BindableEvent _onClick; //Field offset: 0x140

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public ChangeGameModeButtonOld() { }

	private void ApplyVisualState(EGameMode currentGameMode, bool hoverState, bool forced = false) { }

	public IBindableEvent get_OnClick() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	public void Show(EGameMode currentGameMode) { }

	private void ToggleHover(bool hoverState, bool forced = false) { }

}

