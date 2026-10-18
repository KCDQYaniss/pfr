namespace EFT.UI.Gestures;

public sealed class GesturesBindItem : GestureBaseItem
{
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private Button _bindButton; //Field offset: 0x88
	[SerializeField]
	private Image _background; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _commandLabel; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _bindLabel; //Field offset: 0xA0
	private HashSet _availablePhrases; //Field offset: 0xA8
	private ColorMap _colorMap; //Field offset: 0xB0
	private string _caption; //Field offset: 0xB8
	private int _index; //Field offset: 0xC0
	private GesturesQuickPanel _gesturesQuickPanel; //Field offset: 0xC8
	[CompilerGenerated]
	private ECommand <Command>k__BackingField; //Field offset: 0xD0

	public private ECommand Command
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private Color DefaultBackgroundColor
	{
		private get { } //Length: 504
	}

	private Color DefaultTextColor
	{
		private get { } //Length: 504
	}

	private bool IsAudio
	{
		private get { } //Length: 74
	}

	private bool IsAvailable
	{
		private set { } //Length: 105
	}

	public virtual int ItemIndex
	{
		 get { } //Length: 7
	}

	private Color SelectedBackgroundColor
	{
		private get { } //Length: 504
	}

	private Color SelectedTextColor
	{
		private get { } //Length: 504
	}

	public GesturesBindItem() { }

	[CompilerGenerated]
	private void <Awake>b__28_0() { }

	private void Awake() { }

	protected virtual void BindUpdatedHandler(UpdatedGestureBind bind) { }

	[CompilerGenerated]
	public ECommand get_Command() { }

	private Color get_DefaultBackgroundColor() { }

	private Color get_DefaultTextColor() { }

	private bool get_IsAudio() { }

	public virtual int get_ItemIndex() { }

	private Color get_SelectedBackgroundColor() { }

	private Color get_SelectedTextColor() { }

	public void Init(ColorMap colorMap, ECommand command, HashSet availablePhrases, GesturesQuickPanel gesturesQuickPanel) { }

	[CompilerGenerated]
	private void set_Command(ECommand value) { }

	private void set_IsAvailable(bool value) { }

	public void Show(int index, string caption) { }

	protected virtual void UnderPointerChanged(bool isUnderPointer) { }

	private void UpdateVisual(int index, string caption) { }

}

