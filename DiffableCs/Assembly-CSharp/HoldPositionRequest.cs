//Type is in global namespace

public class HoldPositionRequest : BotRequest
{
	private const float distToCatchHit = 12; //Field offset: 0x0
	private const float freeSignDistMeters = 25; //Field offset: 0x0
	public Nullable Direction; //Field offset: 0x70

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public HoldPositionRequest(Player requester, Vector3 dir) { }

	private void ApplyDir(Vector3 dir) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual AICoreActionEnd EndHoldPosition() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public virtual void PlayerDestroy(Player player) { }

	public void SetDirection(Vector3 dir, Vector3 headPos) { }

	public virtual void Take(BotOwner executor) { }

}

