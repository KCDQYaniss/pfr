namespace Sirenix.Serialization;

public sealed class UnityReferenceResolver : IExternalIndexReferenceResolver, ICacheNotificationReceiver
{
	private Dictionary referenceIndexMapping; //Field offset: 0x10
	private List referencedUnityObjects; //Field offset: 0x18

	public UnityReferenceResolver() { }

	public UnityReferenceResolver(List referencedUnityObjects) { }

	public override bool CanReference(object value, out int index) { }

	public List GetReferencedUnityObjects() { }

	public void Reset() { }

	public void SetReferencedUnityObjects(List referencedUnityObjects) { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

	public override bool TryResolveReference(int index, out object value) { }

}

