namespace EFT.GlobalEvents;

public class DeadPlayerEvent : BaseEvent
{
	public string ProfileId; //Field offset: 0x18
	public string AggressorProfileId; //Field offset: 0x20

	public DeadPlayerEvent() { }

	public void Invoke(string victimProfileId, string aggressorProfileId) { }

	public virtual void ParseParams(Dictionary data) { }

	public virtual void Reset() { }

}

