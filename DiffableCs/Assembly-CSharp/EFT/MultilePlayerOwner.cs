namespace EFT;

public class MultilePlayerOwner : InputNode
{
	internal enum EState
	{
		None = 0,
		Started = 1,
		Stopped = 2,
	}

	private List _playerOwners; //Field offset: 0x70
	[CompilerGenerated]
	private IInputTree <InputTree>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private EState <State>k__BackingField; //Field offset: 0x80

	public private IInputTree InputTree
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private EState State
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public MultilePlayerOwner() { }

	internal static MultilePlayerOwner Create(Player[] players, IInputTree inputTree) { }

	[CompilerGenerated]
	public IInputTree get_InputTree() { }

	[CompilerGenerated]
	protected EState get_State() { }

	internal void Run() { }

	[CompilerGenerated]
	private void set_InputTree(IInputTree value) { }

	[CompilerGenerated]
	private void set_State(EState value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	internal override void Stop() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

