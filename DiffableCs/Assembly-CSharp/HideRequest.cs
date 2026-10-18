//Type is in global namespace

public class HideRequest : BotRequest
{

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public HideRequest(Player requester) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual AICoreActionEnd EndHoldPosition() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public virtual void PlayerDestroy(Player player) { }

	public virtual void Take(BotOwner executor) { }

}

