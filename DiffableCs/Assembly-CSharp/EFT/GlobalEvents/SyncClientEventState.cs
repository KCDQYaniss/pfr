namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class SyncClientEventState : SyncEventFromServer
{
	public int PlayerRaidID; //Field offset: 0x18
	public double GameInitialTime; //Field offset: 0x20
	public double EventStartTimestamp; //Field offset: 0x28
	public EEventState EventState; //Field offset: 0x30
	public Vector3 RitualPosition; //Field offset: 0x34
	public string ExitName; //Field offset: 0x40

	public SyncClientEventState() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public void Invoke(int playerId, EEventState eventState, double eventStartTimestamp, Vector3 ritualPosition, double gameInitialTime, string exitName) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

