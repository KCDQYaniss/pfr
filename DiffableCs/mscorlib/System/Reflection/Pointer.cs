namespace System.Reflection;

[CLSCompliant(False)]
public sealed class Pointer : ISerializable
{
	private readonly void* _ptr; //Field offset: 0x10
	private readonly Type _ptrType; //Field offset: 0x18

	private Pointer(void* ptr, Type ptrType) { }

	public static object Box(void* ptr, Type type) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

