namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CutSceneEndEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <cutsceneId>k__BackingField; //Field offset: 0x18

	public private string cutsceneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CutSceneEndEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_cutsceneId() { }

	public void Invoke(string idCutscene) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_cutsceneId(string value) { }

}

