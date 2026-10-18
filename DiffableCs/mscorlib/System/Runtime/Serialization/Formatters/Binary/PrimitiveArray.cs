namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class PrimitiveArray
{
	private InternalPrimitiveTypeE code; //Field offset: 0x10
	private bool[] booleanA; //Field offset: 0x18
	private char[] charA; //Field offset: 0x20
	private double[] doubleA; //Field offset: 0x28
	private short[] int16A; //Field offset: 0x30
	private int[] int32A; //Field offset: 0x38
	private long[] int64A; //Field offset: 0x40
	private sbyte[] sbyteA; //Field offset: 0x48
	private float[] singleA; //Field offset: 0x50
	private ushort[] uint16A; //Field offset: 0x58
	private uint[] uint32A; //Field offset: 0x60
	private ulong[] uint64A; //Field offset: 0x68

	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	internal void SetValue(string value, int index) { }

}

