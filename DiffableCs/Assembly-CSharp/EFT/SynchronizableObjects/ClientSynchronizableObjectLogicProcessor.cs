namespace EFT.SynchronizableObjects;

public sealed class ClientSynchronizableObjectLogicProcessor : SynchronizableObjectLogicProcessor
{
	public ServerAirdropManager ServerAirdropManager; //Field offset: 0x48

	public ClientSynchronizableObjectLogicProcessor() { }

	public void ProcessSyncObjectPackets(List synchronizableObjectPackets) { }

	private void RemoveOutdatedObjects(List synchronizableObjectPackets) { }

	private SynchronizableObject TryTakeActiveObject(int objectID) { }

}

