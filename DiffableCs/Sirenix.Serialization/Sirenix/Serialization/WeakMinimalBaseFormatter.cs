namespace Sirenix.Serialization;

public abstract class WeakMinimalBaseFormatter : IFormatter
{
	protected readonly Type SerializedType; //Field offset: 0x10
	protected readonly bool IsValueType; //Field offset: 0x18

	private override Type Sirenix.Serialization.IFormatter.SerializedType
	{
		private get { } //Length: 5
	}

	public WeakMinimalBaseFormatter(Type serializedType) { }

	public override object Deserialize(IDataReader reader) { }

	protected override object GetUninitializedObject() { }

	protected abstract void Read(ref object value, IDataReader reader) { }

	protected void RegisterReferenceID(object value, IDataReader reader) { }

	public override void Serialize(object value, IDataWriter writer) { }

	private override Type Sirenix.Serialization.IFormatter.get_SerializedType() { }

	protected abstract void Write(ref object value, IDataWriter writer) { }

}

