namespace EFT.Hideout;

public class ComplementaryButton : ButtonFeedback
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__44_0; //Field offset: 0x8
		public static Func <>9__44_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__44_0() { }

		internal string <.ctor>b__44_1() { }

	}

	private const string SECONDS_LEFT = "{0} seconds left"; //Field offset: 0x0
	[SerializeField]
	private Image _background; //Field offset: 0xA8
	[SerializeField]
	private GameObject _hoverObject; //Field offset: 0xB0
	[SerializeField]
	protected Image _icon; //Field offset: 0xB8
	[SerializeField]
	private Sprite _defaultBackground; //Field offset: 0xC0
	[SerializeField]
	private Sprite _selectedBackground; //Field offset: 0xC8
	[SerializeField]
	private Sprite _defaultIcon; //Field offset: 0xD0
	[SerializeField]
	private Sprite _selectedIcon; //Field offset: 0xD8
	private SimpleTooltip _tooltip; //Field offset: 0xE0
	private Action _onHoverStart; //Field offset: 0xE8
	private Action _onHoverEnd; //Field offset: 0xF0
	private Action _onClick; //Field offset: 0xF8
	private bool _isSelected; //Field offset: 0x100
	private int _refreshCooldown; //Field offset: 0x104
	private float _timer; //Field offset: 0x108
	private double _clickTime; //Field offset: 0x110
	private bool _canRefresh; //Field offset: 0x118
	private Func _hoverOnEnabled; //Field offset: 0x120
	private Func _hoverOnDisabled; //Field offset: 0x128
	[CompilerGenerated]
	private bool <IsUnlocked>k__BackingField; //Field offset: 0x130

	private int Cooldown
	{
		private get { } //Length: 24
	}

	public Sprite Icon
	{
		 get { } //Length: 8
	}

	public private bool IsUnlocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private string TooltipMessage
	{
		private get { } //Length: 348
	}

	public ComplementaryButton() { }

	public virtual void Close() { }

	public void CloseTooltip() { }

	private int get_Cooldown() { }

	public Sprite get_Icon() { }

	[CompilerGenerated]
	public bool get_IsUnlocked() { }

	private string get_TooltipMessage() { }

	private void HandleClick() { }

	public void HideHover() { }

	private void OnDisable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler(PointerEventData eventData) { }

	protected virtual void PointerExitHandler(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_IsUnlocked(bool value) { }

	protected void SetIcon(Sprite sprite) { }

	public override void SetSelectedStatus(bool selected) { }

	public void SetTooltipMessages(Func hoverOnEnabled, Func hoverOnDisabled) { }

	public void SetUnlockStatus(bool isUnlocked) { }

	public void Show(Action onClick, Action onHoverStart = null, Action onHoverEnd = null, bool unlocked = true, int refreshCooldown = 0) { }

	protected void ShowTooltip() { }

	private void Update() { }

}

