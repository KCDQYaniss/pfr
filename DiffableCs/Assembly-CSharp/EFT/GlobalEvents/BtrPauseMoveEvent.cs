namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class BtrPauseMoveEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private bool <PauseOn>k__BackingField; //Field offset: 0x18

	public private bool PauseOn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BtrPauseMoveEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_PauseOn() { }

	public void Invoke(bool pauseOn) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PauseOn(bool value) { }

}

