namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class StartGameTimerEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private float <PastTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <SessionSeconds>k__BackingField; //Field offset: 0x1C

	public float PastTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int SessionSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public StartGameTimerEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public float get_PastTime() { }

	[CompilerGenerated]
	public int get_SessionSeconds() { }

	public void Invoke(float pastTimeValue, int sessionSecondsValue) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_PastTime(float value) { }

	[CompilerGenerated]
	public void set_SessionSeconds(int value) { }

}

