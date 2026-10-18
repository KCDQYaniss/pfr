//Type is in global namespace

public class ThrowGrenadeRequestNode : BaseNode
{
	private float _nextUpdTimer; //Field offset: 0x18
	private Vector3 targetPoint; //Field offset: 0x1C
	private bool lastFrameCanShootTotrg; //Field offset: 0x28
	private bool _throwStarted; //Field offset: 0x29

	private ThrowGrenadePointRequest Request
	{
		private get { } //Length: 145
	}

	public ThrowGrenadeRequestNode(BotOwner bot) { }

	[CompilerGenerated]
	private void <UpdateNodeByBrain>b__7_0(ThrowWeap weap) { }

	[CompilerGenerated]
	private void <UpdateNodeByBrain>b__7_1() { }

	protected DoorInteractionStatus DoorOpen() { }

	private ThrowGrenadePointRequest get_Request() { }

	private void RestartFind() { }

	private void SearchAround() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

