namespace EFT.NextObservedPlayer;

public struct ServerFramerateMessage : ISerializableMessage
{
	public float Framerate; //Field offset: 0x0
	public float FixedFramerate; //Field offset: 0x4

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

