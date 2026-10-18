namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal struct RuntimeResolverContext
{
	[CompilerGenerated]
	private ServiceProviderEngineScope <Scope>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RuntimeResolverLock <AcquiredLocks>k__BackingField; //Field offset: 0x8

	public RuntimeResolverLock AcquiredLocks
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ServiceProviderEngineScope Scope
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public RuntimeResolverLock get_AcquiredLocks() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ServiceProviderEngineScope get_Scope() { }

	[CompilerGenerated]
	public void set_AcquiredLocks(RuntimeResolverLock value) { }

	[CompilerGenerated]
	public void set_Scope(ServiceProviderEngineScope value) { }

}

