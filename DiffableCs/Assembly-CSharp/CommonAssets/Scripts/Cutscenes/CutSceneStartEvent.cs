namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CutSceneStartEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int[] <playersIDs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <cutsceneId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <processId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <initTime>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <skipCurrent>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <clientOnly>k__BackingField; //Field offset: 0x31

	public private bool clientOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string cutsceneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float initTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private int[] playersIDs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int processId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool skipCurrent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CutSceneStartEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_clientOnly() { }

	[CompilerGenerated]
	public string get_cutsceneId() { }

	[CompilerGenerated]
	public float get_initTime() { }

	[CompilerGenerated]
	public int[] get_playersIDs() { }

	[CompilerGenerated]
	public int get_processId() { }

	[CompilerGenerated]
	public bool get_skipCurrent() { }

	public void Invoke(string cutsceneId, int processId, int[] playerIds, float timelineInitTime, bool currentSkip = false, bool clientOnly = false) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_clientOnly(bool value) { }

	[CompilerGenerated]
	private void set_cutsceneId(string value) { }

	[CompilerGenerated]
	private void set_initTime(float value) { }

	[CompilerGenerated]
	private void set_playersIDs(int[] value) { }

	[CompilerGenerated]
	private void set_processId(int value) { }

	[CompilerGenerated]
	private void set_skipCurrent(bool value) { }

}

