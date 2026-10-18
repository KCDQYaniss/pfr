namespace System.Text.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class ReferenceResolver
{

	protected ReferenceResolver() { }

	internal override bool ContainsReferenceForCycleDetection(object value) { }

	public abstract string GetReference(object value, out bool alreadyExists) { }

	internal override void PopReferenceForCycleDetection() { }

	internal override void PushReferenceForCycleDetection(object value) { }

}

