//Type is in global namespace

public class GoToExfiltrationPointNode : MoveNode
{
	private const float LEAVE_EXFILTRATION_AREA_SDIST = 1; //Field offset: 0x0
	private AIPeriodAction _gotoPeriod; //Field offset: 0x28
	private Vector3 _pointToLook; //Field offset: 0x30

	public GoToExfiltrationPointNode(BotOwner bot) { }

	private void GoToCompletePoint() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

