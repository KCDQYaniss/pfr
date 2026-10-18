namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[IsReadOnly]
internal struct ServiceCacheKey : IEquatable
{
	[CompilerGenerated]
	private readonly ServiceIdentifier <ServiceIdentifier>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Slot>k__BackingField; //Field offset: 0x10

	public ServiceIdentifier ServiceIdentifier
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	public int Slot
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	[NullableContext(1)]
	public ServiceCacheKey(object key, Type type, int slot) { }

	public ServiceCacheKey(ServiceIdentifier type, int slot) { }

	public override bool Equals(ServiceCacheKey other) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public ServiceIdentifier get_ServiceIdentifier() { }

	[CompilerGenerated]
	public int get_Slot() { }

	public virtual int GetHashCode() { }

}

