namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class BtrIncomingToDestinationGlobalEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <PathID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsAnyPassengerInGroupWithAggressor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsAnyEnemyNearBtr>k__BackingField; //Field offset: 0x21

	public private bool IsAnyEnemyNearBtr
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsAnyPassengerInGroupWithAggressor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string PathID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BtrIncomingToDestinationGlobalEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_IsAnyEnemyNearBtr() { }

	[CompilerGenerated]
	public bool get_IsAnyPassengerInGroupWithAggressor() { }

	[CompilerGenerated]
	public string get_PathID() { }

	public void Invoke(string pathID, bool isAnyPassengerInGroupWithAggressor, bool isAnyEnemyNearBtr) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_IsAnyEnemyNearBtr(bool value) { }

	[CompilerGenerated]
	private void set_IsAnyPassengerInGroupWithAggressor(bool value) { }

	[CompilerGenerated]
	public void set_PathID(string value) { }

}

