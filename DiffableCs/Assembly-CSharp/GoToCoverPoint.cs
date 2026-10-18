//Type is in global namespace

public class GoToCoverPoint : MoveNode
{
	public bool UseBaseLook; //Field offset: 0x28
	private float _nextUpdateTime; //Field offset: 0x2C
	private bool _moving; //Field offset: 0x30
	private bool _start; //Field offset: 0x31

	public GoToCoverPoint(BotOwner bot) { }

	private void InPoint() { }

	private void RestartFind(MoveToCoverActionResultData data) { }

	public virtual void UpdateNodeByBrain(MoveToCoverActionResultData data) { }

}

