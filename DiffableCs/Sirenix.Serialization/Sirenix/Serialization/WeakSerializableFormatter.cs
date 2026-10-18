namespace Sirenix.Serialization;

public sealed class WeakSerializableFormatter : WeakBaseFormatter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public WeakSerializableFormatter <>4__this; //Field offset: 0x10
		public ConstructorInfo constructor; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal ISerializable <.ctor>b__0(SerializationInfo info, StreamingContext context) { }

	}

	private readonly Func ISerializableConstructor; //Field offset: 0x40
	private readonly WeakReflectionFormatter ReflectionFormatter; //Field offset: 0x48

	public WeakSerializableFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	private SerializationInfo ReadSerializationInfo(IDataReader reader) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

	private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer) { }

}

