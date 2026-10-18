namespace System.Text.Json.Serialization.Converters;

internal sealed class FSharpMapConverter`3 : DictionaryDefaultConverter
{
	private readonly Func _mapConstructor; //Field offset: 0x0

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpMapConverter`3() { }

	internal virtual bool get_CanHaveMetadata() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

}

