namespace Microsoft.Extensions.DependencyInjection;

[Nullable(0)]
[NullableContext(1)]
public static class KeyedService
{
	private sealed class AnyKeyObj
	{

		public AnyKeyObj() { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private static readonly object <AnyKey>k__BackingField; //Field offset: 0x0

	public static object AnyKey
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static KeyedService() { }

	[CompilerGenerated]
	public static object get_AnyKey() { }

}

