namespace Sirenix.Serialization;

public class SerializationConfig
{
	private readonly object LOCK; //Field offset: 0x10
	private ISerializationPolicy serializationPolicy; //Field offset: 0x18
	private DebugContext debugContext; //Field offset: 0x20
	public bool AllowDeserializeInvalidData; //Field offset: 0x28

	public DebugContext DebugContext
	{
		 get { } //Length: 574
		 set { } //Length: 340
	}

	public ISerializationPolicy SerializationPolicy
	{
		 get { } //Length: 445
		 set { } //Length: 340
	}

	public SerializationConfig() { }

	public DebugContext get_DebugContext() { }

	public ISerializationPolicy get_SerializationPolicy() { }

	public void ResetToDefault() { }

	public void set_DebugContext(DebugContext value) { }

	public void set_SerializationPolicy(ISerializationPolicy value) { }

}

