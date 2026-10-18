namespace Microsoft.Extensions.DependencyInjection;

public class ServiceProviderOptions
{
	[Nullable(1)]
	internal static readonly ServiceProviderOptions Default; //Field offset: 0x0
	[CompilerGenerated]
	private bool <ValidateScopes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ValidateOnBuild>k__BackingField; //Field offset: 0x11

	public bool ValidateOnBuild
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ValidateScopes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static ServiceProviderOptions() { }

	public ServiceProviderOptions() { }

	[CompilerGenerated]
	public bool get_ValidateOnBuild() { }

	[CompilerGenerated]
	public bool get_ValidateScopes() { }

}

