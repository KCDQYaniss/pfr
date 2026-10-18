namespace Microsoft.Extensions.DependencyInjection;

public interface IKeyedServiceProvider : IServiceProvider
{

	[NullableContext(1)]
	public object GetRequiredKeyedService(Type serviceType, object serviceKey) { }

}

