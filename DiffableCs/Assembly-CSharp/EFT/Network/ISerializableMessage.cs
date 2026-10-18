namespace EFT.Network;

public interface ISerializableMessage
{

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

