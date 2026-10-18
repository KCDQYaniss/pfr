namespace System.Runtime.Serialization;

[ComVisible(True)]
public class ObjectIDGenerator
{
	private static readonly int[] sizes; //Field offset: 0x0
	internal int m_currentCount; //Field offset: 0x10
	internal int m_currentSize; //Field offset: 0x14
	internal long[] m_ids; //Field offset: 0x18
	internal object[] m_objs; //Field offset: 0x20

	private static ObjectIDGenerator() { }

	public ObjectIDGenerator() { }

	private int FindElement(object obj, out bool found) { }

	public override long GetId(object obj, out bool firstTime) { }

	public override long HasId(object obj, out bool firstTime) { }

	private void Rehash() { }

}

