namespace FlyingWormConsole3.LiteNetLib.Utils;

public interface INetSerializable
{

	public void Deserialize(NetDataReader reader) { }

	public void Serialize(NetDataWriter writer) { }

}

