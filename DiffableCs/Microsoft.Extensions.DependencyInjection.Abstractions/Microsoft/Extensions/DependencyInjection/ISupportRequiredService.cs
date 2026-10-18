namespace Microsoft.Extensions.DependencyInjection;

[NullableContext(1)]
public interface ISupportRequiredService
{

	public object GetRequiredService(Type serviceType) { }

}

