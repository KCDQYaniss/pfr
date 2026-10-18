namespace EFT;

public class ErrorMessage : ISerializableMessage
{
	public int errorCode; //Field offset: 0x10

	public ErrorMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

