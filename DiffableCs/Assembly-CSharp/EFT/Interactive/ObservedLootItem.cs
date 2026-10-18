namespace EFT.Interactive;

public sealed class ObservedLootItem : LootItem
{
	private bool _isNetworkGame; //Field offset: 0x118

	public virtual float PhysicsQuality
	{
		 get { } //Length: 4
	}

	public ObservedLootItem() { }

	public void ApplyNetPacket(LootSyncPacket packet) { }

	public static ObservedLootItem CreateLootWithRigidbody(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, MongoID[] validProfiles, out BoxCollider collider, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0) { }

	public virtual float get_PhysicsQuality() { }

	protected virtual ObjectVisibility GetVisibilityChecker() { }

	protected virtual bool IsRigidbodyDone() { }

}

