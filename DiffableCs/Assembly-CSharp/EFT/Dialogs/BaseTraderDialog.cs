namespace EFT.Dialogs;

public abstract class BaseTraderDialog : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public BaseTraderDialogLine line; //Field offset: 0x10
		public BaseTraderDialog <>4__this; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <InitLine>b__0() { }

		internal void <InitLine>g__RedrawDialog|1() { }

	}

	[CompilerGenerated]
	private Action OnExecuteLine; //Field offset: 0x10
	public readonly IDialogContext Context; //Field offset: 0x18
	public readonly TraderDialogTemplate Template; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsBlocked>k__BackingField; //Field offset: 0x28
	protected readonly CompositeDisposable Disposable; //Field offset: 0x30
	protected MongoID lastGeneratedLineId; //Field offset: 0x38
	[CompilerGenerated]
	private IEnumerable <Lines>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private EDialogSide <DialogSide>k__BackingField; //Field offset: 0x58

	public event Action OnExecuteLine
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public EDialogSide DialogSide
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MongoID Id
	{
		 get { } //Length: 43
	}

	public private bool IsBlocked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private IEnumerable Lines
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BaseTraderDialog(IDialogContext context, TraderDialogTemplate template) { }

	[CompilerGenerated]
	private void <Init>b__22_0() { }

	[CompilerGenerated]
	public void add_OnExecuteLine(Action value) { }

	private void ChangeDialogHandler(BaseTraderDialogLine line) { }

	public override void Dispose() { }

	public bool ExecuteLineByIndex(int index) { }

	[CompilerGenerated]
	public EDialogSide get_DialogSide() { }

	public MongoID get_Id() { }

	[CompilerGenerated]
	public bool get_IsBlocked() { }

	[CompilerGenerated]
	public IEnumerable get_Lines() { }

	protected void Init(IEnumerable lines) { }

	private void InitLine(BaseTraderDialogLine line) { }

	private void OnBlockDialog(bool isBlocked) { }

	[CompilerGenerated]
	public void remove_OnExecuteLine(Action value) { }

	[CompilerGenerated]
	protected void set_DialogSide(EDialogSide value) { }

	[CompilerGenerated]
	private void set_IsBlocked(bool value) { }

	[CompilerGenerated]
	private void set_Lines(IEnumerable value) { }

}

