namespace BitPacking;

public sealed class Vector2Quantizer
{
	private readonly FloatQuantizer _xFloatQuantizer; //Field offset: 0x10
	private readonly FloatQuantizer _yFloatQuantizer; //Field offset: 0x2C

	public Vector2Quantizer(float xMin, float xMax, float xResolution, float yMin, float yMax, float yResolution, bool checkBounds = false) { }

	public void Read(IBitReaderStream bitReaderStream, out Vector2 value) { }

	public Vector2 Write(IBitWriterStream bitWriterStream, Vector2 value) { }

}

