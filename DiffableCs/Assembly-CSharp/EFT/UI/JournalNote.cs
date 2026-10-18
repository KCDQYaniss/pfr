namespace EFT.UI;

[Obfuscation(Exclude = True)]
public class JournalNote : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private const string TRUNCATE_STRING = "..."; //Field offset: 0x0
	private static JournalNote _selectedNote; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _noteName; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _noteDescription; //Field offset: 0x78
	[SerializeField]
	private Button _deleteNoteButton; //Field offset: 0x80
	[SerializeField]
	private Button _editNoteButton; //Field offset: 0x88
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x90
	[SerializeField]
	private RectTransform _mask; //Field offset: 0x98
	[SerializeField]
	private int _maxTitleLength; //Field offset: 0xA0
	[CompilerGenerated]
	private Note <Note>k__BackingField; //Field offset: 0xA8
	private float _minHeight; //Field offset: 0xB0
	private float _minTextHeight; //Field offset: 0xB4
	private Action _editButtonPressed; //Field offset: 0xB8
	private Action _destroyButtonPressed; //Field offset: 0xC0

	public private Note Note
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public JournalNote() { }

	[CompilerGenerated]
	private void <Awake>b__17_0() { }

	[CompilerGenerated]
	private void <Awake>b__17_1() { }

	private void Awake() { }

	public void ButtonClickHandler() { }

	[CompilerGenerated]
	public Note get_Note() { }

	public void HideFull() { }

	public void Init(Action editButtonPressed, Action destroyButtonPressed) { }

	private void OnDestroy() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_Note(Note value) { }

	internal void Show(Note note) { }

	public void ShowFull() { }

}

