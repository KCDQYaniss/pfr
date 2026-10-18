//Type is in global namespace

[DisallowMultipleComponent]
public class UsableHandsPrefab : WeaponPrefab
{
	[Header("Bone name for item")]
	public string UsableItemBoneName; //Field offset: 0x228
	public Transform ItemSpawnTransform; //Field offset: 0x230

	public UsableHandsPrefab() { }

	protected virtual void CacheInternalObjects() { }

}

