//Type is in global namespace

public class DeactivateMineNode : MoveNode
{
	private const float CLOSE_SDIST = 5.29; //Field offset: 0x0
	private float _nextAct; //Field offset: 0x28
	private AIPeriodAction _periodCHeck; //Field offset: 0x30
	private bool lineCastResult; //Field offset: 0x38

	public DeactivateMineNode(BotOwner bot) { }

	private void DoDeactivateProcess() { }

	private void GoToClose(Vector3 pos) { }

	private void RayCastCheck() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

