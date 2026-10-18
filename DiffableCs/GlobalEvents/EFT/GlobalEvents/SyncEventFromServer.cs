namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public abstract class SyncEventFromServer : SyncEvent, ISyncFromServerEvent, ISyncEvent, IEvent
{

	protected SyncEventFromServer() { }

}

