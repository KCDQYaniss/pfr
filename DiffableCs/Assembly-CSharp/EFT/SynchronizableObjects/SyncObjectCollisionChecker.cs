namespace EFT.SynchronizableObjects;

public sealed class SyncObjectCollisionChecker : MonoBehaviour
{
	[SerializeField]
	private SynchronizableObject _synchronizableObject; //Field offset: 0x20

	public SyncObjectCollisionChecker() { }

	private void Awake() { }

	public void OnTriggerEnter(Collider colliderComponent) { }

}

