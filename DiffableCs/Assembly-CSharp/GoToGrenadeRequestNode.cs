//Type is in global namespace

public class GoToGrenadeRequestNode : MoveNode
{
	private float _nextUpdTimer; //Field offset: 0x28

	private ThrowGrenadeRequest Request
	{
		private get { } //Length: 145
	}

	public GoToGrenadeRequestNode(BotOwner bot) { }

	private ThrowGrenadeRequest get_Request() { }

	private void InPoint() { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

