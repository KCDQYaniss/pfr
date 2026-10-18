//Type is in global namespace

public class GoToFollowRequest : MoveNode
{
	public bool UseBaseLook; //Field offset: 0x28
	private float _nextUpdTimer; //Field offset: 0x2C
	private FollowMeRequest _followRequest; //Field offset: 0x30

	public GoToFollowRequest(BotOwner bot) { }

	private void InPoint() { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

