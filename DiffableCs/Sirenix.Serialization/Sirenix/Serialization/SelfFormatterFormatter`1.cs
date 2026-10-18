namespace Sirenix.Serialization;

public sealed class SelfFormatterFormatter`1 : BaseFormatter
{

	public SelfFormatterFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

}

