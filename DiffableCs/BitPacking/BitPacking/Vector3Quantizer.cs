namespace BitPacking;

public sealed class Vector3Quantizer
{
	private readonly FloatQuantizer _xFloatQuantizer; //Field offset: 0x10
	private readonly FloatQuantizer _yFloatQuantizer; //Field offset: 0x2C
	private readonly FloatQuantizer _zFloatQuantizer; //Field offset: 0x48

	public Vector3Quantizer(float xMin, float xMax, float xResolution, float yMin, float yMax, float yResolution, float zMin, float zMax, float zResolution, bool checkBounds = false) { }

	public Bounds GetBounds() { }

	public void Read(IBitReaderStream bitReaderStream, out Vector3 value) { }

	public virtual string ToString() { }

	public Vector3 Write(IBitWriterStream bitWriterStream, Vector3 value) { }

}

