namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitGroupSizeEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PointId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary <Sizes>k__BackingField; //Field offset: 0x20

	public private int PointId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Dictionary Sizes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TransitGroupSizeEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PointId() { }

	[CompilerGenerated]
	public Dictionary get_Sizes() { }

	public void Invoke(int pointId, Dictionary playerSizes) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PointId(int value) { }

	[CompilerGenerated]
	private void set_Sizes(Dictionary value) { }

}

