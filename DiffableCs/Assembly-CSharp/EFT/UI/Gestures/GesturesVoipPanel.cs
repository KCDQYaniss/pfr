namespace EFT.UI.Gestures;

public sealed class GesturesVoipPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <VoipEnabled>b__12_0() { }

		internal string <VoipEnabled>b__12_1() { }

	}

	[SerializeField]
	private Button _statusButton; //Field offset: 0x70
	[SerializeField]
	private Image _statusImage; //Field offset: 0x78
	[SerializeField]
	private HoverTooltipArea _tooltipArea; //Field offset: 0x80
	[SerializeField]
	private Button _reportButton; //Field offset: 0x88
	[SerializeField]
	[Space]
	private Sprite _enabledSprite; //Field offset: 0x90
	[SerializeField]
	private Sprite _disabledSprite; //Field offset: 0x98
	private IPlayerVoipController _controller; //Field offset: 0xA0
	private Action _voipInitBinding; //Field offset: 0xA8

	private bool IsVoipAvailable
	{
		private get { } //Length: 117
	}

	public GesturesVoipPanel() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	[CompilerGenerated]
	private void <Awake>b__10_1() { }

	[CompilerGenerated]
	private void <Show>b__11_0(bool _) { }

	private void Awake() { }

	public virtual void Close() { }

	private bool get_IsVoipAvailable() { }

	public void Show(IPlayerVoipController controller) { }

	private void VoipEnabled(bool value) { }

}

