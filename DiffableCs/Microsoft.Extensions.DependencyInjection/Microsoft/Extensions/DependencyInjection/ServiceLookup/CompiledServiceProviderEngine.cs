namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal abstract class CompiledServiceProviderEngine : ServiceProviderEngine
{
	[CompilerGenerated]
	private readonly ILEmitResolverBuilder <ResolverBuilder>k__BackingField; //Field offset: 0x10

	public ILEmitResolverBuilder ResolverBuilder
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[RequiresDynamicCode("Creates DynamicMethods")]
	public CompiledServiceProviderEngine(ServiceProvider provider) { }

	[CompilerGenerated]
	public ILEmitResolverBuilder get_ResolverBuilder() { }

	public virtual Func RealizeService(ServiceCallSite callSite) { }

}

