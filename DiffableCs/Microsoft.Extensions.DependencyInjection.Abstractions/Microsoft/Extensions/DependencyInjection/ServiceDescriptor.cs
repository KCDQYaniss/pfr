namespace Microsoft.Extensions.DependencyInjection;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[Nullable(0)]
[NullableContext(1)]
public class ServiceDescriptor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Func factory; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal object <.ctor>b__0(IServiceProvider sp) { }

	}

	[CompilerGenerated]
	private readonly ServiceLifetime <Lifetime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly object <ServiceKey>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Type <ServiceType>k__BackingField; //Field offset: 0x20
	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes::PublicConstructors (3))]
	private Type _implementationType; //Field offset: 0x28
	private object _implementationInstance; //Field offset: 0x30
	private object _implementationFactory; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func ImplementationFactory
	{
		 get { } //Length: 118
	}

	[Nullable(2)]
	public object ImplementationInstance
	{
		[NullableContext(2)]
		 get { } //Length: 15
	}

	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes::PublicConstructors (3))]
	[Nullable(2)]
	public Type ImplementationType
	{
		[NullableContext(2)]
		 get { } //Length: 15
	}

	public bool IsKeyedService
	{
		 get { } //Length: 9
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2, 1})]
	public Func KeyedImplementationFactory
	{
		 get { } //Length: 120
	}

	[Nullable(2)]
	public object KeyedImplementationInstance
	{
		[NullableContext(2)]
		 get { } //Length: 27
	}

	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes::PublicConstructors (3))]
	[Nullable(2)]
	public Type KeyedImplementationType
	{
		[NullableContext(2)]
		 get { } //Length: 27
	}

	public ServiceLifetime Lifetime
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	[Nullable(2)]
	public object ServiceKey
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public Type ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime lifetime) { }

	public ServiceDescriptor(Type serviceType, object serviceKey, Type implementationType, ServiceLifetime lifetime) { }

	public ServiceDescriptor(Type serviceType, object instance) { }

	public ServiceDescriptor(Type serviceType, object serviceKey, object instance) { }

	public ServiceDescriptor(Type serviceType, Func factory, ServiceLifetime lifetime) { }

	public ServiceDescriptor(Type serviceType, object serviceKey, Func factory, ServiceLifetime lifetime) { }

	private ServiceDescriptor(Type serviceType, object serviceKey, ServiceLifetime lifetime) { }

	public static ServiceDescriptor Describe(Type serviceType, Type implementationType, ServiceLifetime lifetime) { }

	private static ServiceDescriptor DescribeKeyed(object serviceKey, ServiceLifetime lifetime) { }

	public static ServiceDescriptor DescribeKeyed(Type serviceType, object serviceKey, Type implementationType, ServiceLifetime lifetime) { }

	public Func get_ImplementationFactory() { }

	[NullableContext(2)]
	public object get_ImplementationInstance() { }

	[NullableContext(2)]
	public Type get_ImplementationType() { }

	public bool get_IsKeyedService() { }

	public Func get_KeyedImplementationFactory() { }

	[NullableContext(2)]
	public object get_KeyedImplementationInstance() { }

	[NullableContext(2)]
	public Type get_KeyedImplementationType() { }

	[CompilerGenerated]
	public ServiceLifetime get_Lifetime() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_ServiceKey() { }

	[CompilerGenerated]
	public Type get_ServiceType() { }

	internal Type GetImplementationType() { }

	public static ServiceDescriptor Scoped(Type service, Type implementationType) { }

	public static ServiceDescriptor Singleton() { }

	public static ServiceDescriptor Singleton(Type service, Type implementationType) { }

	public static ServiceDescriptor Singleton(TService implementationInstance) { }

	public static ServiceDescriptor Singleton(Type serviceType, object implementationInstance) { }

	private static void ThrowNonKeyedDescriptor() { }

	public virtual string ToString() { }

	public static ServiceDescriptor Transient(Type service, Type implementationType) { }

}

