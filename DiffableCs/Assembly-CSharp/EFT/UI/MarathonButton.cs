namespace EFT.UI;

public sealed class MarathonButton : ButtonFeedback
{
	private class ButtonContext
	{
		public Image icon; //Field offset: 0x10
		public TextMeshProUGUI label; //Field offset: 0x18
		public TextMeshProUGUI description; //Field offset: 0x20
		public Image background; //Field offset: 0x28
		public Image hover; //Field offset: 0x30

		public ButtonContext() { }

	}

	private class ButtonState
	{
		public Sprite icon; //Field offset: 0x10
		public Sprite backgroundIcon; //Field offset: 0x18
		public Sprite hoverIcon; //Field offset: 0x20
		public string labelText; //Field offset: 0x28
		public string descriptionText; //Field offset: 0x30
		public HoverColor textColor; //Field offset: 0x38
		public HoverColor iconColor; //Field offset: 0x40

		public ButtonState() { }

		public void Apply(ButtonContext context) { }

		public void Hover(ButtonContext context, bool hovered) { }

	}

	private class HoverColor
	{
		public Color Idle; //Field offset: 0x10
		public Color Hover; //Field offset: 0x20

		public HoverColor() { }

	}

	[SerializeField]
	private ButtonContext _button; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _buttonDescriptionCanvasGroup; //Field offset: 0xB0
	[SerializeField]
	private readonly Dictionary _stateData; //Field offset: 0xB8
	private Tween _imageTween; //Field offset: 0xC0
	private Tween _textTween; //Field offset: 0xC8
	private bool _pointerOnButton; //Field offset: 0xD0
	private RaidSettings _raidSettings; //Field offset: 0xD8
	private Action _toggleMarathon; //Field offset: 0xE0

	public MarathonButton() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	public void Show(RaidSettings raidSettings, ESideType side, Action toggleMarathon) { }

	private void ToggleHover(bool state, bool forced = false) { }

}

