namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class HalloweenSummonStartedEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private Vector3 <PointPosition>k__BackingField; //Field offset: 0x18

	public private Vector3 PointPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public HalloweenSummonStartedEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Vector3 get_PointPosition() { }

	public void Invoke(Vector3 centerPoint) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PointPosition(Vector3 value) { }

}

