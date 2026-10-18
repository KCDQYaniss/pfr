//Type is in global namespace

public class WarnPlayerRequestGoNode : MoveNode
{
	private const float CANT_FIND_WAY_SECONDS = 15; //Field offset: 0x0
	private const float DIST_TO_PLAYER = 3; //Field offset: 0x0
	private float _nextUpdTimer; //Field offset: 0x28
	private bool _isFirstTryComplete; //Field offset: 0x2C
	private float _firstTimeTry; //Field offset: 0x30

	private WarnPlayerRequest Request
	{
		private get { } //Length: 39
	}

	public WarnPlayerRequestGoNode(BotOwner bot) { }

	private void ComeToPlayer() { }

	private WarnPlayerRequest get_Request() { }

	private void GoTo() { }

	private void InPoint() { }

	private void LookAround() { }

	private bool RestartFind() { }

	private void RunTo() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

