namespace EFT.UI;

public abstract class HeroActionButton`1 : ButtonFeedback
{
	internal enum EHeroButtonAvailableState
	{
		Available = 0,
		Unavailable = 1,
	}

	internal class HeroActionButtonData
	{
		[Header("Colors")]
		public Color IdleTextColor; //Field offset: 0x0
		public Sprite PmcIdleSprite; //Field offset: 0x0
		public Color BgHoverUnavailableColor; //Field offset: 0x0
		public Sprite BgHoverUnavailable; //Field offset: 0x0
		public Color BgHoverAvailableColor; //Field offset: 0x0
		public Sprite BgHoverAvailable; //Field offset: 0x0
		public Color BgIdleUnavailableColor; //Field offset: 0x0
		public Sprite BgIdleUnavailable; //Field offset: 0x0
		public Color BgIdleAvailableColor; //Field offset: 0x0
		public Sprite BgIdleAvailable; //Field offset: 0x0
		public Sprite PmcHoverSprite; //Field offset: 0x0
		public Color DescriptionIconUnavailableColor; //Field offset: 0x0
		public Color DescriptionIconAvailableColor; //Field offset: 0x0
		public Sprite DescriptionIconAvailable; //Field offset: 0x0
		public string DescriptionUnavailableKey; //Field offset: 0x0
		public string DescriptionAvailableKey; //Field offset: 0x0
		public string MainTextUnavailableKey; //Field offset: 0x0
		[Header("Localization Keys")]
		public string MainTextAvailableKey; //Field offset: 0x0
		public Color HoverUnavailableColor; //Field offset: 0x0
		public Color PmcColor; //Field offset: 0x0
		public Color HoverTextColor; //Field offset: 0x0
		public Sprite DescriptionIconUnavailable; //Field offset: 0x0
		public Sprite[] PmcHoverAnimationSprites; //Field offset: 0x0

		public HeroActionButtonData() { }

	}

	[SerializeField]
	protected SpriteAnimationPlayer _spriteAnimationPlayer; //Field offset: 0x0
	protected HeroActionButtonData _currentButtonData; //Field offset: 0x0
	protected EHeroButtonAvailableState _currentAvailabilityState; //Field offset: 0x0
	private Tween _descriptionFadeTween; //Field offset: 0x0
	private Tween _iconColorTween; //Field offset: 0x0
	private Tween _descriptionColorTween; //Field offset: 0x0
	private Tween _labelCrossFadeTween; //Field offset: 0x0
	private Tween _imageTween; //Field offset: 0x0
	[SerializeField]
	protected float _descriptionFadeDuration; //Field offset: 0x0
	[SerializeField]
	protected float _descriptionMaxAlpha; //Field offset: 0x0
	private Color _currentDescriptionIconColor; //Field offset: 0x0
	[SerializeField]
	protected float _descriptionMinAlpha; //Field offset: 0x0
	[SerializeField]
	private Image _backgroundIdle; //Field offset: 0x0
	[SerializeField]
	private Image _backgroundHovered; //Field offset: 0x0
	[SerializeField]
	private Image _buttonDescriptionIcon; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _buttonDescriptionCanvasGroup; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _buttonDescription; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _buttonLabelHoverCanvasGroup; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _buttonLabelCanvasGroup; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _buttonLabelHover; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _buttonLabel; //Field offset: 0x0
	[SerializeField]
	protected Image _pmcImage; //Field offset: 0x0
	private readonly BindableEvent _onClick; //Field offset: 0x0

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	protected abstract Dictionary StateData
	{
		 get { } //Length: 0
	}

	protected HeroActionButton`1() { }

	private static void ApplySprite(Image image, Sprite sprite, Color color) { }

	protected void ApplyVisualState(TStateKey stateKey, EHeroButtonAvailableState availabilityState, bool hoverState, bool forced = false) { }

	public IBindableEvent get_OnClick() { }

	protected abstract Dictionary get_StateData() { }

	protected override string GetDescriptionText() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	private void ToggleHover(bool hoverState, bool forced = false) { }

}

