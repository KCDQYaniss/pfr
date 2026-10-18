//Type is in global namespace

public class GoToPointTacticalNode : TaclicalMoveNode
{

	protected virtual Vector3 MainTargetPosition
	{
		 get { } //Length: 53
	}

	public GoToPointTacticalNode(BotOwner bot) { }

	protected virtual Vector3 get_MainTargetPosition() { }

	protected virtual void LookSimple() { }

	protected virtual void MoverToMainTarget(CustomNavigationPoint navigationPoint) { }

	protected virtual void MoveToMainTarget() { }

}

