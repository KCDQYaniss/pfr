namespace System.Text.Json.Serialization.Converters;

internal sealed class FSharpListConverter`2 : IEnumerableDefaultConverter
{
	private readonly Func _listConstructor; //Field offset: 0x0

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpListConverter`2() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

}

