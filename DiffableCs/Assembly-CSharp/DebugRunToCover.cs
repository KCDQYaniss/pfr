//Type is in global namespace

public class DebugRunToCover : MoveNode
{
	private float _updatePointTimer; //Field offset: 0x28
	private float _updatePointTimer2; //Field offset: 0x2C
	private float _nextPoint; //Field offset: 0x30
	private List _lsit; //Field offset: 0x38
	private Nullable _lastTarget; //Field offset: 0x40

	public DebugRunToCover(BotOwner bot) { }

	[CompilerGenerated]
	private bool <UpdateNodeByBrain>b__6_0(GroupPoint x) { }

	protected void RestartFindTime() { }

	protected void RestartFindTime2() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

