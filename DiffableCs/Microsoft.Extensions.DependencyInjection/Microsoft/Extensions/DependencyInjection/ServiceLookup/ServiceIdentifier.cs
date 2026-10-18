namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct ServiceIdentifier : IEquatable
{
	[CompilerGenerated]
	private readonly object <ServiceKey>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Type <ServiceType>k__BackingField; //Field offset: 0x8

	public bool IsConstructedGenericType
	{
		 get { } //Length: 42
	}

	[Nullable(2)]
	public object ServiceKey
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 4
	}

	public Type ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ServiceIdentifier(object serviceKey, Type serviceType) { }

	public override bool Equals(ServiceIdentifier other) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public static ServiceIdentifier FromDescriptor(ServiceDescriptor serviceDescriptor) { }

	public static ServiceIdentifier FromServiceType(Type type) { }

	public bool get_IsConstructedGenericType() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_ServiceKey() { }

	[CompilerGenerated]
	public Type get_ServiceType() { }

	public ServiceIdentifier GetGenericTypeDefinition() { }

	public virtual int GetHashCode() { }

	[NullableContext(2)]
	public virtual string ToString() { }

}

