namespace Sirenix.Serialization;

public sealed class EnumSerializer`1 : Serializer
{

	private static EnumSerializer`1() { }

	public EnumSerializer`1() { }

	public virtual T ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, T value, IDataWriter writer) { }

}

