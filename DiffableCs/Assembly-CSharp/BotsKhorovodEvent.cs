//Type is in global namespace

public class BotsKhorovodEvent : BaseBotsEvent
{
	public bool IsActive; //Field offset: 0x20
	public readonly Khorovod Config; //Field offset: 0x28
	private readonly BotsEventsController _botsEventsController; //Field offset: 0x30

	public virtual List LayersToActivate
	{
		 get { } //Length: 212
	}

	public virtual List LayersToDeActivate
	{
		 get { } //Length: 95
	}

	public BotsKhorovodEvent(BotsEventsController botsEventsController, BotsList botsList, Khorovod khorovodConfig) { }

	public virtual void Activate() { }

	protected virtual bool CanActivate(BotOwner bot) { }

	public virtual void Dispose() { }

	public virtual List get_LayersToActivate() { }

	public virtual List get_LayersToDeActivate() { }

	public void ManualUpdate() { }

	private void OnBotAddHandler(BotOwner botOwner) { }

}

