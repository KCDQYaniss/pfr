namespace EFT.SynchronizableObjects;

public interface ISynchronizableLogic
{

	public void CollisionEnter(Collider colliderComponent) { }

	public void Init(int objectId, Vector3 position, Vector3 rotation) { }

	public void InitStaticObject() { }

	public void ManualUpdate(float deltaTime) { }

	public void ReturnToPool() { }

	public void SetSyncObject(SynchronizableObject syncObject) { }

	public void TakeFromPool() { }

	public void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

