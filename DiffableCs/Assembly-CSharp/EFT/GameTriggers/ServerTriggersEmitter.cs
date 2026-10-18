namespace EFT.GameTriggers;

public class ServerTriggersEmitter : TriggersEmitter
{
	private HashSet _clientAuthorityTriggers; //Field offset: 0x30

	public ServerTriggersEmitter() { }

	[CompilerGenerated]
	private void <.ctor>b__1_0(TriggerEventClient eventFromClient) { }

	public virtual void Dispose() { }

	public virtual void Emit(string triggerId, int originPlayerRaidId) { }

	public void SetClientAuthorityTriggers() { }

}

