namespace System.Runtime.Serialization;

internal sealed class ValueTypeFixupInfo
{
	private readonly long _containerID; //Field offset: 0x10
	private readonly FieldInfo _parentField; //Field offset: 0x18
	private readonly int[] _parentIndex; //Field offset: 0x20

	public long ContainerID
	{
		 get { } //Length: 5
	}

	public FieldInfo ParentField
	{
		 get { } //Length: 5
	}

	public int[] ParentIndex
	{
		 get { } //Length: 5
	}

	public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex) { }

	public long get_ContainerID() { }

	public FieldInfo get_ParentField() { }

	public int[] get_ParentIndex() { }

}

