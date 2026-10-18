namespace Sirenix.Serialization;

public class ComplexTypeSerializer`1 : Serializer
{
	private static readonly bool ComplexTypeMayBeBoxedValueType; //Field offset: 0x0
	private static readonly bool ComplexTypeIsAbstract; //Field offset: 0x0
	private static readonly bool ComplexTypeIsNullable; //Field offset: 0x0
	private static readonly bool ComplexTypeIsValueType; //Field offset: 0x0
	private static readonly Type TypeOf_T; //Field offset: 0x0
	private static readonly bool AllowDeserializeInvalidDataForT; //Field offset: 0x0
	private static readonly Dictionary FormattersByPolicy; //Field offset: 0x0
	private static readonly object FormattersByPolicy_LOCK; //Field offset: 0x0
	private static readonly ISerializationPolicy UnityPolicy; //Field offset: 0x0
	private static readonly ISerializationPolicy StrictPolicy; //Field offset: 0x0
	private static readonly ISerializationPolicy EverythingPolicy; //Field offset: 0x0
	private static IFormatter UnityPolicyFormatter; //Field offset: 0x0
	private static IFormatter StrictPolicyFormatter; //Field offset: 0x0
	private static IFormatter EverythingPolicyFormatter; //Field offset: 0x0

	private static ComplexTypeSerializer`1() { }

	public ComplexTypeSerializer`1() { }

	private static IFormatter GetBaseFormatter(ISerializationPolicy serializationPolicy) { }

	public virtual T ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, T value, IDataWriter writer) { }

}

