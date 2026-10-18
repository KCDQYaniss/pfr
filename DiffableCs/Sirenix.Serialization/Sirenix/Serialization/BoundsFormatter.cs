namespace Sirenix.Serialization;

public class BoundsFormatter : MinimalBaseFormatter
{
	private static readonly Serializer Vector3Serializer; //Field offset: 0x0

	private static BoundsFormatter() { }

	public BoundsFormatter() { }

	protected virtual void Read(ref Bounds value, IDataReader reader) { }

	protected virtual void Write(ref Bounds value, IDataWriter writer) { }

}

