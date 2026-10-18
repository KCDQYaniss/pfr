namespace System.Text.Json.Serialization.Converters;

internal sealed class FSharpSetConverter`2 : IEnumerableDefaultConverter
{
	private readonly Func _setConstructor; //Field offset: 0x0

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpSetConverter`2() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

}

