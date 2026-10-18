namespace Microsoft.Extensions.Logging;

[NullableContext(1)]
public interface ILoggingBuilder
{

	public IServiceCollection Services
	{
		 get { } //Length: 0
	}

	public IServiceCollection get_Services() { }

}

