namespace System.Text.Json.Serialization;

internal sealed class PreserveReferenceHandler : ReferenceHandler
{

	public PreserveReferenceHandler() { }

	internal virtual ReferenceResolver CreateResolver(bool writing) { }

	public virtual ReferenceResolver CreateResolver() { }

}

