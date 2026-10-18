namespace EFT.UI.Gestures;

public sealed class GesturesAudioSubItem : GestureBaseItem
{
	public EPhraseTrigger PhraseTrigger; //Field offset: 0x80
	public bool IsSituational; //Field offset: 0x84
	[SerializeField]
	private Image _background; //Field offset: 0x88
	[SerializeField]
	private GameObject _situationalMarker; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _textField; //Field offset: 0x98
	[SerializeField]
	[Space]
	private GameObject _bindObject; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _bindLabel; //Field offset: 0xA8
	private Sprite _defaultBackground; //Field offset: 0xB0
	private Sprite _selectedBackground; //Field offset: 0xB8
	private Color _defaultAudioColor; //Field offset: 0xC0
	private Color _selectedAudioColor; //Field offset: 0xD0
	private ECommand _command; //Field offset: 0xE0

	public virtual int ItemIndex
	{
		 get { } //Length: 7
	}

	public GesturesAudioSubItem() { }

	[CompilerGenerated]
	private bool <Show>b__14_0(KeyValuePair x) { }

	protected virtual void BindUpdatedHandler(UpdatedGestureBind bind) { }

	public virtual int get_ItemIndex() { }

	public void Show(Sprite defaultBackground, Sprite selectedBackground, Color defaultAudioColor, Color selectedAudioColor, GestureCommands binds) { }

	protected virtual void UnderPointerChanged(bool isUnderPointer) { }

}

