namespace BitPacking;

[Extension]
public static class FloatQuantizerExtensions
{

	[Extension]
	public static float DequantizeUIntValue(FloatQuantizer floatQuantizer, uint value) { }

	[Extension]
	public static uint QuantizeFloatValue(FloatQuantizer floatQuantizer, float value) { }

	[Extension]
	public static void Read(FloatQuantizer floatQuantizer, IBitReaderStream bitReaderStream, out float value) { }

	[Extension]
	public static float Write(FloatQuantizer floatQuantizer, IBitWriterStream bitWriterStream, float value) { }

}

