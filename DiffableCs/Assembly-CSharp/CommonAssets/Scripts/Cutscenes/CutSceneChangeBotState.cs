namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CutSceneChangeBotState : SyncEventFromServer
{
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x18

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CutSceneChangeBotState() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	public void Invoke(bool activeState) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

}

