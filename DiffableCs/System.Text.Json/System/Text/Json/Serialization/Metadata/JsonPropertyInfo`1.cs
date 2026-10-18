namespace System.Text.Json.Serialization.Metadata;

internal sealed class JsonPropertyInfo`1 : JsonPropertyInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action typedSetter; //Field offset: 0x0

		public <>c__DisplayClass10_0() { }

		internal void <SetSetter>b__0(object obj, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public Action untypedSet; //Field offset: 0x0

		public <>c__DisplayClass10_1() { }

		internal void <SetSetter>b__1(object obj, T value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Func typedPredicate; //Field offset: 0x0

		public <>c__DisplayClass15_0() { }

		internal bool <SetShouldSerialize>b__0(object obj, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_1
	{
		public Func untypedPredicate; //Field offset: 0x0

		public <>c__DisplayClass15_1() { }

		internal bool <SetShouldSerialize>b__1(object obj, T value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Func typedGetter; //Field offset: 0x0

		public <>c__DisplayClass9_0() { }

		internal object <SetGetter>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public Func untypedGet; //Field offset: 0x0

		public <>c__DisplayClass9_1() { }

		internal T <SetGetter>b__1(object obj) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__ShouldSerializeIgnoreConditionNever; //Field offset: 0x0
		public static Func <1>__ShouldSerializeIgnoreConditionAlways; //Field offset: 0x0
		public static Func <2>__ShouldSerializeIgnoreWhenWritingDefault; //Field offset: 0x0

	}

	private Func _typedGet; //Field offset: 0x0
	private Action _typedSet; //Field offset: 0x0
	private Func _shouldSerializeTyped; //Field offset: 0x0
	private JsonConverter _typedEffectiveConverter; //Field offset: 0x0

	internal JsonConverter EffectiveConverter
	{
		internal get { } //Length: 8
	}

	internal Func Get
	{
		internal get { } //Length: 8
		internal set { } //Length: 38
	}

	internal virtual bool PropertyTypeCanBeNull
	{
		internal get { } //Length: 3
	}

	internal Action Set
	{
		internal set { } //Length: 38
	}

	internal Func ShouldSerialize
	{
		internal get { } //Length: 8
		internal set { } //Length: 38
	}

	internal JsonPropertyInfo`1(Type declaringType, JsonTypeInfo declaringTypeInfo, JsonSerializerOptions options) { }

	[CompilerGenerated]
	internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionAlways|31_1(object _, T value) { }

	[CompilerGenerated]
	internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionNever|31_0(object _, T value) { }

	[CompilerGenerated]
	internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreWhenWritingDefault|31_2(object _, T value) { }

	virtual void ConfigureIgnoreCondition(Nullable ignoreCondition) { }

	internal virtual JsonParameterInfo CreateJsonParameterInfo(JsonParameterInfoValues parameterInfoValues) { }

	virtual void DetermineEffectiveConverter(JsonTypeInfo jsonTypeInfo) { }

	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	internal virtual void DetermineReflectionPropertyAccessors(MemberInfo memberInfo, bool useNonPublicAccessors) { }

	internal JsonConverter get_EffectiveConverter() { }

	internal Func get_Get() { }

	internal virtual bool get_PropertyTypeCanBeNull() { }

	internal Func get_ShouldSerialize() { }

	internal virtual bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer) { }

	internal virtual bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer) { }

	private static bool IsDefaultValue(T value) { }

	internal void set_Get(Func value) { }

	internal void set_Set(Action value) { }

	internal void set_ShouldSerialize(Func value) { }

	virtual void SetGetter(Delegate getter) { }

	virtual void SetSetter(Delegate setter) { }

	virtual void SetShouldSerialize(Delegate predicate) { }

}

