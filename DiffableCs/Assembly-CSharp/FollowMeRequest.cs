//Type is in global namespace

public class FollowMeRequest : BotRequest
{
	public const float EXECUTER_FAR_SQRT = 64; //Field offset: 0x0
	public const float MAX_SQRT_DIST = 2500; //Field offset: 0x0
	public const float MAX_SQRT_DIST_FROM_TAKE_POINT = 40000; //Field offset: 0x0
	public Vector3 StartExecuterPosition; //Field offset: 0x70
	private float _startExecute; //Field offset: 0x7C

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 6
	}

	public FollowMeRequest(Player requester) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual bool CanStartExecute(BotOwner executor) { }

	public Vector3 CurTragte() { }

	public virtual AICoreActionEnd EndHoldPosition() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public bool IsExecuterFar() { }

	public bool IsExecuterTooFar() { }

	private bool IsIamFarMyZone() { }

	public virtual void PlayerDestroy(Player player) { }

}

