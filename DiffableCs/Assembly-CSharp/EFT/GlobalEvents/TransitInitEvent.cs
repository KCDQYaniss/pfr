namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitInitEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary <Points>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary <CompletedQuestRequirementMetByPointId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ushort <TransitionCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <EventPlayer>k__BackingField; //Field offset: 0x32

	public private Dictionary CompletedQuestRequirementMetByPointId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool EventPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Dictionary Points
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ushort TransitionCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public TransitInitEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Dictionary get_CompletedQuestRequirementMetByPointId() { }

	[CompilerGenerated]
	public bool get_EventPlayer() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public Dictionary get_Points() { }

	[CompilerGenerated]
	public ushort get_TransitionCount() { }

	public void Invoke(int playerId, Dictionary pointsById, Transit transit) { }

	public void Invoke(int playerId, Dictionary pointsById, Transit transit, IReadOnlyDictionary completedQuestRequirementMetByPointId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_CompletedQuestRequirementMetByPointId(Dictionary value) { }

	[CompilerGenerated]
	private void set_EventPlayer(bool value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_Points(Dictionary value) { }

	[CompilerGenerated]
	private void set_TransitionCount(ushort value) { }

}

