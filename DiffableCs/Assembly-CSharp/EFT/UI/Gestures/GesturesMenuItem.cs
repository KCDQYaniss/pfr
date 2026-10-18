namespace EFT.UI.Gestures;

public sealed class GesturesMenuItem : GestureBaseItem
{
	public EInteraction Gesture; //Field offset: 0x80
	[SerializeField]
	private Image _iconImage; //Field offset: 0x88
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x90
	[SerializeField]
	[Space]
	private GameObject _bindObject; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _bindLabel; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _commandLabel; //Field offset: 0xA8
	private Sprite _defaultBackground; //Field offset: 0xB0
	private Sprite _selectedBackground; //Field offset: 0xB8
	private ECommand _command; //Field offset: 0xC0

	public Sprite Icon
	{
		 set { } //Length: 33
	}

	public virtual int ItemIndex
	{
		 get { } //Length: 8
	}

	public GesturesMenuItem() { }

	[CompilerGenerated]
	private bool <Show>b__13_0(KeyValuePair x) { }

	protected virtual void BindUpdatedHandler(UpdatedGestureBind bind) { }

	public virtual int get_ItemIndex() { }

	public void set_Icon(Sprite value) { }

	public void Show(Sprite defaultSubColor, Sprite selectedSubColor, GestureCommands binds) { }

	protected virtual void UnderPointerChanged(bool isUnderPointer) { }

}

