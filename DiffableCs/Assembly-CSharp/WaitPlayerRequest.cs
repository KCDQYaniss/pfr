//Type is in global namespace

internal class WaitPlayerRequest : BotRequest
{
	private const float PERIOD_WAIT = 5; //Field offset: 0x0
	private float _endTime; //Field offset: 0x70

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public WaitPlayerRequest(Player requester) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual AICoreActionEnd EndHoldPosition() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public virtual void Take(BotOwner executor) { }

}

