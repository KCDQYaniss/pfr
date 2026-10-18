namespace EFT.UI;

public class Tooltip : UIElement
{
	[SerializeField]
	private RectTransform _mainTransform; //Field offset: 0x70
	[SerializeField]
	private RectTransform _boundsTransform; //Field offset: 0x78
	private Coroutine _showCoroutine; //Field offset: 0x80
	private Vector2 _offset; //Field offset: 0x88
	private bool _isPositionLocked; //Field offset: 0x90
	private LayoutElement _layoutElement; //Field offset: 0x98
	private float _defaultWidth; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <Locked>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private bool <Displayed>k__BackingField; //Field offset: 0xA5

	public private bool Displayed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool Locked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Tooltip() { }

	protected void ApplyMaxWidth(Nullable maxWidth) { }

	protected override void Awake() { }

	public virtual void Close() { }

	public virtual void Display() { }

	[CompilerGenerated]
	public bool get_Displayed() { }

	[CompilerGenerated]
	public bool get_Locked() { }

	private void InitializeLayoutElement() { }

	public void LockPosition(Vector2 position) { }

	protected void OnApplicationFocus(bool hasFocus) { }

	protected void OnDisable() { }

	protected void RefreshPosition() { }

	[CompilerGenerated]
	private void set_Displayed(bool value) { }

	[CompilerGenerated]
	private void set_Locked(bool value) { }

	private void SetPosition(Vector2 position) { }

	protected CancellationToken Show(Vector2 offset = null, float delay = 0, bool locked = false) { }

	public void UnlockPosition() { }

	protected override void Update() { }

}

