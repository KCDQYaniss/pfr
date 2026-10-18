//Type is in global namespace

public class GoToPointRequestNode : MoveNode
{
	private float _nextUpdTimer; //Field offset: 0x28
	private Vector3 targetPoint; //Field offset: 0x2C
	private bool lastFrameCanShootTotrg; //Field offset: 0x38

	private GoToPointRequest Request
	{
		private get { } //Length: 145
	}

	public GoToPointRequestNode(BotOwner bot) { }

	private GoToPointRequest get_Request() { }

	private void InPoint() { }

	private void RestartFind() { }

	private void SearchAround() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

