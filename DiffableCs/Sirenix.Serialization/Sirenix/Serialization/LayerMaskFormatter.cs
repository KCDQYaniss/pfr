namespace Sirenix.Serialization;

public class LayerMaskFormatter : MinimalBaseFormatter
{
	private static readonly Serializer IntSerializer; //Field offset: 0x0

	private static LayerMaskFormatter() { }

	public LayerMaskFormatter() { }

	protected virtual void Read(ref LayerMask value, IDataReader reader) { }

	protected virtual void Write(ref LayerMask value, IDataWriter writer) { }

}

