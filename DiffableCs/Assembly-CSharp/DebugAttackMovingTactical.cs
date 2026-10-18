//Type is in global namespace

public class DebugAttackMovingTactical : TaclicalMoveNode
{
	private CustomNavigationPoint _curTarget; //Field offset: 0xB0
	private float _lastChange; //Field offset: 0xB8

	public DebugAttackMovingTactical(BotOwner bot) { }

	public virtual void Dispose() { }

	private bool GoodNextPoint(GroupPoint arg) { }

	protected virtual void LookSimple() { }

	protected virtual void MoverToMainTarget(CustomNavigationPoint navigationPoint) { }

	private void OnInCoverChange(bool arg1, CustomNavigationPoint arg2) { }

	private CustomNavigationPoint RefreshTargetPoint() { }

}

