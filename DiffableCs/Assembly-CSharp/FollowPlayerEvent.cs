//Type is in global namespace

public class FollowPlayerEvent : BaseBotsEvent
{

	public virtual List LayersToActivate
	{
		 get { } //Length: 212
	}

	public virtual List LayersToDeActivate
	{
		 get { } //Length: 95
	}

	public FollowPlayerEvent(BotsList botsList) { }

	public virtual void Activate() { }

	protected virtual bool CanActivate(BotOwner bot) { }

	public void DebugActivate() { }

	public virtual void Dispose() { }

	public virtual List get_LayersToActivate() { }

	public virtual List get_LayersToDeActivate() { }

	private bool IsEventAllowedOnLocation() { }

	private void OnBotAdd(BotOwner bot) { }

}

