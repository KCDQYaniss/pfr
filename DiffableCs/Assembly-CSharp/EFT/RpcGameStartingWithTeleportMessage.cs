namespace EFT;

public sealed class RpcGameStartingWithTeleportMessage : ISerializableMessage
{
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ExfiltrationId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private string <EntryPoint>k__BackingField; //Field offset: 0x20

	public string EntryPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int ExfiltrationId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public RpcGameStartingWithTeleportMessage() { }

	public RpcGameStartingWithTeleportMessage(Vector3 position, int exfiltrationId, string entryPoint) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_EntryPoint() { }

	[CompilerGenerated]
	public int get_ExfiltrationId() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_EntryPoint(string value) { }

	[CompilerGenerated]
	public void set_ExfiltrationId(int value) { }

	[CompilerGenerated]
	public void set_Position(Vector3 value) { }

}

