namespace EFT.AssetsManager;

public abstract class PoolSafeMonoBehaviour : MonoBehaviour, IPoolComponent
{
	public static readonly Type[] ExcludedBaseClasses; //Field offset: 0x0
	[ClassStateStorageIgnore]
	public ClassStateStorage OriginalState; //Field offset: 0x20

	private static PoolSafeMonoBehaviour() { }

	protected PoolSafeMonoBehaviour() { }

	private override bool EFT.AssetsManager.IPoolComponent.get_enabled() { }

	private override void EFT.AssetsManager.IPoolComponent.set_enabled(bool value) { }

	public override void InheritRoleModelData(IPoolComponent roleModel) { }

	public override void OnCreatePoolObject(AssetPoolObject assetPoolObject) { }

	public override void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject) { }

	public override void OnGetFromPool(AssetPoolObject assetPoolObject) { }

	public override void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	private void StoreClassState() { }

}

