namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CutSceneReconnectEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <playersID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <cutsceneId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <initTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <processId>k__BackingField; //Field offset: 0x2C

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

	public private int playersID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int processId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CutSceneReconnectEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_cutsceneId() { }

	[CompilerGenerated]
	public float get_initTime() { }

	[CompilerGenerated]
	public int get_playersID() { }

	[CompilerGenerated]
	public int get_processId() { }

	public void Invoke(string idCutscene, int playerId, float timelineInitTime, int idProcess) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_cutsceneId(string value) { }

	[CompilerGenerated]
	private void set_initTime(float value) { }

	[CompilerGenerated]
	private void set_playersID(int value) { }

	[CompilerGenerated]
	private void set_processId(int value) { }

}

