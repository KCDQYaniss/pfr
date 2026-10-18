namespace Sirenix.Serialization;

public interface IFormatter`1 : IFormatter
{

	public T Deserialize(IDataReader reader) { }

	public void Serialize(T value, IDataWriter writer) { }

}

