namespace System.Text.Json.Serialization;

internal sealed class IgnoreReferenceHandler : ReferenceHandler
{

	public IgnoreReferenceHandler() { }

	public virtual ReferenceResolver CreateResolver() { }

}

