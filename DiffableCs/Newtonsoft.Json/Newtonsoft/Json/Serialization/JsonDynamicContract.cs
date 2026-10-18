namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class JsonDynamicContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func <PropertyNameResolver>k__BackingField; //Field offset: 0xC8
	private readonly ThreadSafeStore _callSiteGetters; //Field offset: 0xD0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 1, 1, 1, 1, 2, 1})]
	private readonly ThreadSafeStore _callSiteSetters; //Field offset: 0xD8

	public JsonPropertyCollection Properties
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func PropertyNameResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public JsonDynamicContract(Type underlyingType) { }

	private static CallSite CreateCallSiteGetter(string name) { }

	private static CallSite CreateCallSiteSetter(string name) { }

	[CompilerGenerated]
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	public Func get_PropertyNameResolver() { }

	[CompilerGenerated]
	public void set_PropertyNameResolver(Func value) { }

	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

