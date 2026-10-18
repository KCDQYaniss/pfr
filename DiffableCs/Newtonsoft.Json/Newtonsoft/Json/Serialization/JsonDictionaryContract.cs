namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonDictionaryContract : JsonContainerContract
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func <DictionaryKeyResolver>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; //Field offset: 0xD8
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0xE0
	private Type _genericWrapperType; //Field offset: 0xE8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor _genericWrapperCreator; //Field offset: 0xF0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func _genericTemporaryDictionaryCreator; //Field offset: 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0x100
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0x108
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor _overrideCreator; //Field offset: 0x110
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor _parameterizedCreator; //Field offset: 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x120

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func DictionaryKeyResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Type DictionaryKeyType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Type DictionaryValueType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool HasParameterizedCreator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	internal bool HasParameterizedCreatorInternal
	{
		internal get { } //Length: 163
	}

	internal JsonContract KeyContract
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor OverrideCreator
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal ObjectConstructor ParameterizedCreator
	{
		internal get { } //Length: 339
	}

	internal bool ShouldCreateWrapper
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[NullableContext(1)]
	public JsonDictionaryContract(Type underlyingType) { }

	[NullableContext(1)]
	internal IDictionary CreateTemporaryDictionary() { }

	[NullableContext(1)]
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[CompilerGenerated]
	public Func get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	public bool get_HasParameterizedCreator() { }

	internal bool get_HasParameterizedCreatorInternal() { }

	[CompilerGenerated]
	internal JsonContract get_KeyContract() { }

	public ObjectConstructor get_OverrideCreator() { }

	internal ObjectConstructor get_ParameterizedCreator() { }

	[CompilerGenerated]
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	public void set_DictionaryKeyResolver(Func value) { }

	[CompilerGenerated]
	public void set_HasParameterizedCreator(bool value) { }

	[CompilerGenerated]
	internal void set_KeyContract(JsonContract value) { }

	public void set_OverrideCreator(ObjectConstructor value) { }

}

