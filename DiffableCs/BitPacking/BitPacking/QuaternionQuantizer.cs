namespace BitPacking;

public class QuaternionQuantizer
{
	private float _resolution; //Field offset: 0x10
	private readonly BitPackingTag _tag; //Field offset: 0x14

	public QuaternionQuantizer(float resolution, BitPackingTag tag) { }

	public void Read(IBitReaderStream reader, out Quaternion quaternion) { }

	public void Write(IBitWriterStream writer, Quaternion quaternion) { }

}

