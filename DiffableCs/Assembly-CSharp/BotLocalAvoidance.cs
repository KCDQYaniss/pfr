//Type is in global namespace

public class BotLocalAvoidance : BotData
{
	private const float SpeedDesrease = 0.9; //Field offset: 0x0
	private const float SpeedIncrease = 1.2; //Field offset: 0x0
	private const float MaxDistToOfBypass = 0.3; //Field offset: 0x0
	private const float DistToBeClose = 2.1; //Field offset: 0x0
	private const float DistToBeCloseExt = 2.52; //Field offset: 0x0
	private Vector3 _totalOffset; //Field offset: 0x18
	private Vector3 _notLinkedOffset; //Field offset: 0x24
	private bool _haveOffset; //Field offset: 0x30
	private float _blockUntil; //Field offset: 0x34
	private bool thisFrameDecrease; //Field offset: 0x38
	private bool ClientDisableAvoidance; //Field offset: 0x39
	private bool DisableAvoidance; //Field offset: 0x3A

	public Vector3 NotLinkedOffset
	{
		 get { } //Length: 19
	}

	public Vector3 TotalOffset
	{
		 get { } //Length: 19
	}

	public BotLocalAvoidance(BotOwner owner) { }

	private void AddPower(Vector3 dir) { }

	public void DropOffset() { }

	public Vector3 get_NotLinkedOffset() { }

	public Vector3 get_TotalOffset() { }

	public void ManualUpdate() { }

	private void OffsetDecrease() { }

	public void UpdateTotal(float coef) { }

}

