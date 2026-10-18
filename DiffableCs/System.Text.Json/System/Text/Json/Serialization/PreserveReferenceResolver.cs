namespace System.Text.Json.Serialization;

internal sealed class PreserveReferenceResolver : ReferenceResolver
{
	private uint _referenceCount; //Field offset: 0x10
	private readonly Dictionary _referenceIdToObjectMap; //Field offset: 0x18
	private readonly Dictionary _objectToReferenceIdMap; //Field offset: 0x20

	public PreserveReferenceResolver(bool writing) { }

	public virtual string GetReference(object value, out bool alreadyExists) { }

}

