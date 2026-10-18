//Type is in global namespace

public abstract class AReserveWayAction : MonoBehaviour
{
	protected EReserveWayResult CurrentResult; //Field offset: 0x20
	private float _nextCheckClose; //Field offset: 0x24
	private bool _lastDesicion; //Field offset: 0x28

	public abstract Vector3 GoTo
	{
		 get { } //Length: 0
	}

	public abstract Vector3 LookShootTo
	{
		 get { } //Length: 0
	}

	protected AReserveWayAction() { }

	public abstract void AutoFix() { }

	protected void CheckPoint(Vector3 point, string data) { }

	protected void CheckWayFromParent(string nameInfo, Vector3 from) { }

	public abstract void ComeTo(BotOwner bot) { }

	public abstract void DrawGizmos() { }

	public abstract Vector3 get_GoTo() { }

	public abstract Vector3 get_LookShootTo() { }

	public abstract EReserveWayResult ManualUpdate(BotOwner owner) { }

	public abstract void RefreshBot() { }

	public abstract void RefreshData() { }

	public void SetCurrentUser(BotOwner bot) { }

	public override void SetLeaveUser(BotOwner owner) { }

	public override float TimeToUse(BotOwner owner) { }

}

