namespace EFT.UI;

public class NotesTaskDescription : UIElement
{
	[CompilerGenerated]
	private struct <LoadSprite>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest quest; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		public NotesTaskDescription <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TMP_Text _title; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _location; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _scavIdentification; //Field offset: 0x80
	[SerializeField]
	private GameObject _descriptionContainer; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _description; //Field offset: 0x90
	[SerializeField]
	private Image _titleBack; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _status; //Field offset: 0xA0
	[SerializeField]
	private GameObject _loader; //Field offset: 0xA8
	[SerializeField]
	private Image _questImage; //Field offset: 0xB0
	[SerializeField]
	private Image _typeIcon; //Field offset: 0xB8
	[SerializeField]
	private TMP_Text _type; //Field offset: 0xC0
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0xC8
	[SerializeField]
	private GameObject _timeIcon; //Field offset: 0xD0
	[SerializeField]
	private TMP_Text _timeLimitedText; //Field offset: 0xD8
	[SerializeField]
	private GameObject _dailyBackground; //Field offset: 0xE0
	[SerializeField]
	private QuestTierAccessoryIconView _tierAccessoryIconView; //Field offset: 0xE8
	[SerializeField]
	private ColorMap _titleBackColors; //Field offset: 0xF0
	[SerializeField]
	private ColorMap _textColors; //Field offset: 0xF8

	public NotesTaskDescription() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<LoadSprite>d__19))]
	private Task LoadSprite(Quest quest, IImageLoader session) { }

	internal void Show(Quest quest, IImageLoader session) { }

}

