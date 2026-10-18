namespace EFT.Tutorial;

public abstract class BaseTutorialHintController : IDisposable
{
	[CompilerGenerated]
	private readonly TutorialHintData <Hint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Player <Player>k__BackingField; //Field offset: 0x18
	private readonly Action _showHint; //Field offset: 0x20
	private readonly Action _closeHint; //Field offset: 0x28

	protected TutorialHintData Hint
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected BaseTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint) { }

	protected void CloseHint() { }

	public override void Dispose() { }

	[CompilerGenerated]
	protected TutorialHintData get_Hint() { }

	[CompilerGenerated]
	protected Player get_Player() { }

	protected void ShowHint() { }

}

