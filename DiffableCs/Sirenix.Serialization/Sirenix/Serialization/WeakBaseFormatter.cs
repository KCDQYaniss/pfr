namespace Sirenix.Serialization;

public abstract class WeakBaseFormatter : IFormatter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public MethodInfo info; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <CreateCallback>b__0(object value, StreamingContext context) { }

		internal void <CreateCallback>b__1(object value, StreamingContext context) { }

	}

	internal sealed class SerializationCallback : MulticastDelegate
	{

		public SerializationCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object value, StreamingContext context, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(object value, StreamingContext context) { }

	}

	protected readonly Type SerializedType; //Field offset: 0x10
	protected readonly SerializationCallback[] OnSerializingCallbacks; //Field offset: 0x18
	protected readonly SerializationCallback[] OnSerializedCallbacks; //Field offset: 0x20
	protected readonly SerializationCallback[] OnDeserializingCallbacks; //Field offset: 0x28
	protected readonly SerializationCallback[] OnDeserializedCallbacks; //Field offset: 0x30
	protected readonly bool IsValueType; //Field offset: 0x38
	protected readonly bool ImplementsISerializationCallbackReceiver; //Field offset: 0x39
	protected readonly bool ImplementsIDeserializationCallback; //Field offset: 0x3A
	protected readonly bool ImplementsIObjectReference; //Field offset: 0x3B

	private override Type Sirenix.Serialization.IFormatter.SerializedType
	{
		private get { } //Length: 5
	}

	public WeakBaseFormatter(Type serializedType) { }

	private static SerializationCallback CreateCallback(MethodInfo info) { }

	public override object Deserialize(IDataReader reader) { }

	protected abstract void DeserializeImplementation(ref object value, IDataReader reader) { }

	private static SerializationCallback[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List list) { }

	protected override object GetUninitializedObject() { }

	protected void InvokeOnDeserializingCallbacks(object value, DeserializationContext context) { }

	protected void RegisterReferenceID(object value, IDataReader reader) { }

	public override void Serialize(object value, IDataWriter writer) { }

	protected abstract void SerializeImplementation(ref object value, IDataWriter writer) { }

	private override Type Sirenix.Serialization.IFormatter.get_SerializedType() { }

}

