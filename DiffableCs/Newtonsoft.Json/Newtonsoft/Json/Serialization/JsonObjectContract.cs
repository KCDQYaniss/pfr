namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract
{
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Nullable <MissingMemberHandling>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Nullable <ItemRequired>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private Nullable <ItemNullValueHandling>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func <ExtensionDataNameResolver>k__BackingField; //Field offset: 0xF8
	internal bool ExtensionDataIsJToken; //Field offset: 0x100
	private Nullable _hasRequiredOrDefaultValueProperties; //Field offset: 0x101
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor _overrideCreator; //Field offset: 0x108
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor _parameterizedCreator; //Field offset: 0x110
	private JsonPropertyCollection _creatorParameters; //Field offset: 0x118
	private Type _extensionDataValueType; //Field offset: 0x120

	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters
	{
		[NullableContext(1)]
		 get { } //Length: 206
	}

	public ExtensionDataGetter ExtensionDataGetter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func ExtensionDataNameResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExtensionDataSetter ExtensionDataSetter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Type ExtensionDataValueType
	{
		 get { } //Length: 8
		 set { } //Length: 284
	}

	internal bool HasRequiredOrDefaultValueProperties
	{
		internal get { } //Length: 687
	}

	public Nullable ItemNullValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable ItemRequired
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MemberSerialization MemberSerialization
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Nullable MissingMemberHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
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
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	[Nullable(1)]
	public JsonPropertyCollection Properties
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	[NullableContext(1)]
	public JsonObjectContract(Type underlyingType) { }

	[NullableContext(1)]
	public JsonPropertyCollection get_CreatorParameters() { }

	[CompilerGenerated]
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	public Func get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	public Type get_ExtensionDataValueType() { }

	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[CompilerGenerated]
	public Nullable get_ItemNullValueHandling() { }

	[CompilerGenerated]
	public Nullable get_ItemRequired() { }

	[CompilerGenerated]
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	public Nullable get_MissingMemberHandling() { }

	public ObjectConstructor get_OverrideCreator() { }

	internal ObjectConstructor get_ParameterizedCreator() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	internal object GetUninitializedObject() { }

	[CompilerGenerated]
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	[CompilerGenerated]
	public void set_ExtensionDataNameResolver(Func value) { }

	[CompilerGenerated]
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	public void set_ItemNullValueHandling(Nullable value) { }

	[CompilerGenerated]
	public void set_ItemRequired(Nullable value) { }

	[CompilerGenerated]
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	public void set_MissingMemberHandling(Nullable value) { }

	public void set_OverrideCreator(ObjectConstructor value) { }

	internal void set_ParameterizedCreator(ObjectConstructor value) { }

}

