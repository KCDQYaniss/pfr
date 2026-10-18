//Type is in global namespace

public class GoToBody : MoveNode
{
	private float _updatePointTimer; //Field offset: 0x28
	private bool _moving; //Field offset: 0x2C
	private Vector3 targetPoint; //Field offset: 0x30

	public GoToBody(BotOwner bot) { }

	private void InPoint() { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

