//Type is in global namespace

public class GoToDoorOpen : MoveNode
{
	private float _updatePointTimer; //Field offset: 0x28
	private bool _moving; //Field offset: 0x2C

	private OpenDoorRequest Request
	{
		private get { } //Length: 145
	}

	public GoToDoorOpen(BotOwner bot) { }

	private OpenDoorRequest get_Request() { }

	private void InPoint() { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

