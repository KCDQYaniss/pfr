namespace System.Text.Json.Serialization;

internal sealed class IgnoreReferenceResolver : ReferenceResolver
{
	private Stack _stackForCycleDetection; //Field offset: 0x10

	public IgnoreReferenceResolver() { }

	internal virtual bool ContainsReferenceForCycleDetection(object value) { }

	public virtual string GetReference(object value, out bool alreadyExists) { }

	internal virtual void PopReferenceForCycleDetection() { }

	internal virtual void PushReferenceForCycleDetection(object value) { }

}

