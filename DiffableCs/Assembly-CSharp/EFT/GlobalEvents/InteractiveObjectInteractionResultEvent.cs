namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class InteractiveObjectInteractionResultEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private EDoorState <InteractionResult>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ObjectID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Operatable>k__BackingField; //Field offset: 0x34

	public private EDoorState InteractionResult
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string ObjectID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool Operatable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public InteractiveObjectInteractionResultEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public EDoorState get_InteractionResult() { }

	[CompilerGenerated]
	public string get_ObjectID() { }

	[CompilerGenerated]
	public bool get_Operatable() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	public void Invoke(WorldInteractiveObject interactiveObject, EDoorState result) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_InteractionResult(EDoorState value) { }

	[CompilerGenerated]
	private void set_ObjectID(string value) { }

	[CompilerGenerated]
	private void set_Operatable(bool value) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

}

