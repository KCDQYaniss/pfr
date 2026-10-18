//Type is in global namespace

internal sealed class ClientNetworkGameWorld : ClientGameWorld
{

	public ClientNetworkGameWorld() { }

	protected virtual GrenadeFactory CreateGrenadeFactory() { }

	protected virtual LootItem CreateLootWithRigidbody(GameObject lootObject, Item item, string objectName, bool randomRotation, MongoID[] validProfiles, out BoxCollider objectCollider, bool syncable = true, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0) { }

	public virtual void DeActivateTripwire(TripwireSynchronizableObject tripwire) { }

	public virtual Task InitLevel(ItemFactory itemFactory, ObjectsFactoryConfig config, bool loadBundlesAndCreatePools = true, List resources = null, IProgress progress = null, CancellationToken ct = null) { }

	public virtual bool IsLocalGame() { }

	public virtual void PlantTripwire(Item item1, int playerRaidId, Vector3 fromPosition, Vector3 toPosition) { }

	public virtual void RegisterPlayer(IPlayer iPlayer) { }

	public virtual void TriggerTripwire(TripwireSynchronizableObject tripwire) { }

}

