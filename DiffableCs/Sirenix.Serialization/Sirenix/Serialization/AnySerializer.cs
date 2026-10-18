namespace Sirenix.Serialization;

public sealed class AnySerializer : Serializer
{
	private static readonly ISerializationPolicy UnityPolicy; //Field offset: 0x0
	private static readonly ISerializationPolicy StrictPolicy; //Field offset: 0x8
	private static readonly ISerializationPolicy EverythingPolicy; //Field offset: 0x10
	private readonly Type SerializedType; //Field offset: 0x10
	private readonly bool IsEnum; //Field offset: 0x18
	private readonly bool IsValueType; //Field offset: 0x19
	private readonly bool MayBeBoxedValueType; //Field offset: 0x1A
	private readonly bool IsAbstract; //Field offset: 0x1B
	private readonly bool IsNullable; //Field offset: 0x1C
	private readonly bool AllowDeserializeInvalidData; //Field offset: 0x1D
	private IFormatter UnityPolicyFormatter; //Field offset: 0x20
	private IFormatter StrictPolicyFormatter; //Field offset: 0x28
	private IFormatter EverythingPolicyFormatter; //Field offset: 0x30
	private readonly Dictionary FormattersByPolicy; //Field offset: 0x38
	private readonly object FormattersByPolicy_LOCK; //Field offset: 0x40

	private static AnySerializer() { }

	public AnySerializer(Type serializedType) { }

	private IFormatter GetBaseFormatter(ISerializationPolicy serializationPolicy) { }

	public virtual object ReadValueWeak(IDataReader reader) { }

	public virtual void WriteValueWeak(string name, object value, IDataWriter writer) { }

}

