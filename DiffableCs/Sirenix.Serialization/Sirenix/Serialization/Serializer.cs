namespace Sirenix.Serialization;

public abstract class Serializer
{
	private static readonly Dictionary PrimitiveReaderWriterTypes; //Field offset: 0x0
	private static readonly object LOCK; //Field offset: 0x8
	private static readonly Dictionary Weak_ReaderWriterCache; //Field offset: 0x10
	private static readonly Dictionary Strong_ReaderWriterCache; //Field offset: 0x18

	private static Serializer() { }

	protected Serializer() { }

	private static Serializer Create(Type type, bool allowWeakfallback) { }

	[Conditional("UNITY_EDITOR")]
	protected static void FireOnSerializedType(Type type) { }

	public static Serializer Get() { }

	public static Serializer Get(Type type) { }

	private static Serializer Get(Type type, bool allowWeakFallback) { }

	public static Serializer GetForValue(object value) { }

	private static void LogAOTError(Type type, ExecutionEngineException ex) { }

	public abstract object ReadValueWeak(IDataReader reader) { }

	public void WriteValueWeak(object value, IDataWriter writer) { }

	public abstract void WriteValueWeak(string name, object value, IDataWriter writer) { }

}

