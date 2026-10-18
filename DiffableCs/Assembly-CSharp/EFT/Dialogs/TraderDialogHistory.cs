namespace EFT.Dialogs;

public sealed class TraderDialogHistory : IEnumerable, IEnumerable, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__17_0(DialogHistoryLine l) { }

	}

	[IsReadOnly]
	internal struct DialogHistoryLine
	{
		public readonly EDialogSide DialogSide; //Field offset: 0x0
		private readonly DialogLineTextConstructor _lineTextConstructor; //Field offset: 0x8
		[CompilerGenerated]
		private readonly string <SpeakerName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly MongoID <Id>k__BackingField; //Field offset: 0x18

		public MongoID Id
		{
			[CompilerGenerated]
			 get { } //Length: 21
		}

		public string Line
		{
			 get { } //Length: 291
		}

		public string SpeakerName
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public DialogHistoryLine(EDialogSide dialogSide, string speakerName, DialogLineTextConstructor textConstructor, MongoID id) { }

		[CompilerGenerated]
		public MongoID get_Id() { }

		public string get_Line() { }

		[CompilerGenerated]
		public string get_SpeakerName() { }

	}

	private const int HISTORY_SIZE = 100; //Field offset: 0x0
	private readonly int _capacity; //Field offset: 0x10
	private readonly Queue _lines; //Field offset: 0x18
	[CompilerGenerated]
	private MongoID <SourceId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnLineAdded; //Field offset: 0x38

	public event Action OnLineAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private MongoID SourceId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public TraderDialogHistory(int capacity = 100) { }

	[CompilerGenerated]
	public void add_OnLineAdded(Action value) { }

	public void AddLine(BaseTraderDialogLine line) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public MongoID get_SourceId() { }

	public override IEnumerator GetEnumerator() { }

	public void Init(MongoID sourceId) { }

	[CompilerGenerated]
	public void remove_OnLineAdded(Action value) { }

	[CompilerGenerated]
	private void set_SourceId(MongoID value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

