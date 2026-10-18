namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CorrectCutsceneTimerEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private float <elapsedTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <cutsceneId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <processId>k__BackingField; //Field offset: 0x28

	public private string cutsceneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float elapsedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private int processId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CorrectCutsceneTimerEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_cutsceneId() { }

	[CompilerGenerated]
	public float get_elapsedTime() { }

	[CompilerGenerated]
	public int get_processId() { }

	public void Invoke(float timeElapsed, string idCutscene, int idProcess) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_cutsceneId(string value) { }

	[CompilerGenerated]
	private void set_elapsedTime(float value) { }

	[CompilerGenerated]
	private void set_processId(int value) { }

}

