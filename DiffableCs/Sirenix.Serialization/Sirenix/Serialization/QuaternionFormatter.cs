namespace Sirenix.Serialization;

public class QuaternionFormatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static QuaternionFormatter() { }

	public QuaternionFormatter() { }

	protected virtual void Read(ref Quaternion value, IDataReader reader) { }

	protected virtual void Write(ref Quaternion value, IDataWriter writer) { }

}

