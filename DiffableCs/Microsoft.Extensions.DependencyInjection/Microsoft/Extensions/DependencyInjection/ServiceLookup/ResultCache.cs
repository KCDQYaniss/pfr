namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

internal struct ResultCache
{
	[CompilerGenerated]
	private CallSiteResultCacheLocation <Location>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ServiceCacheKey <Key>k__BackingField; //Field offset: 0x8

	public ServiceCacheKey Key
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public CallSiteResultCacheLocation Location
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	internal ResultCache(CallSiteResultCacheLocation lifetime, ServiceCacheKey cacheKey) { }

	public ResultCache(ServiceLifetime lifetime, ServiceIdentifier serviceIdentifier, int slot) { }

	[CompilerGenerated]
	[IsReadOnly]
	public ServiceCacheKey get_Key() { }

	[CompilerGenerated]
	[IsReadOnly]
	public CallSiteResultCacheLocation get_Location() { }

	[NullableContext(1)]
	public static ResultCache None(Type serviceType) { }

	[CompilerGenerated]
	public void set_Key(ServiceCacheKey value) { }

	[CompilerGenerated]
	public void set_Location(CallSiteResultCacheLocation value) { }

}

