namespace System.Text.Json.Serialization.Metadata;

public sealed class JsonTypeInfo`1 : JsonTypeInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Func untypedCreateObject; //Field offset: 0x0

		public <>c__DisplayClass29_0() { }

		internal T <SetCreateObject>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_1
	{
		public Func typedDelegate; //Field offset: 0x0

		public <>c__DisplayClass29_1() { }

		internal object <SetCreateObject>b__1() { }

	}

	private Action _serialize; //Field offset: 0x0
	private Func _typedCreateObject; //Field offset: 0x0
	[CompilerGenerated]
	private readonly JsonConverter <EffectiveConverter>k__BackingField; //Field offset: 0x0

	[Nullable(1)]
	internal JsonConverter EffectiveConverter
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Action SerializeHandler
	{
		 get { } //Length: 8
	}

	internal JsonTypeInfo`1(JsonConverter converter, JsonSerializerOptions options) { }

	virtual JsonPropertyInfo CreateJsonPropertyInfo(JsonTypeInfo declaringTypeInfo, Type declaringType, JsonSerializerOptions options) { }

	virtual JsonPropertyInfo CreatePropertyInfoForTypeInfo() { }

	[CompilerGenerated]
	internal JsonConverter get_EffectiveConverter() { }

	public Action get_SerializeHandler() { }

	internal void Serialize(Utf8JsonWriter writer, in T rootValue, object rootValueBoxed = null) { }

	internal virtual void SerializeAsObject(Utf8JsonWriter writer, object rootValue) { }

	virtual void SetCreateObject(Delegate createObject) { }

}

