namespace EFT.AssetsManager;

public interface IPoolComponent
{

	public bool enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_enabled() { }

	public void InheritRoleModelData(IPoolComponent roleModel) { }

	public void OnCreatePoolObject(AssetPoolObject assetPoolObject) { }

	public void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject) { }

	public void OnGetFromPool(AssetPoolObject assetPoolObject) { }

	public void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	public void set_enabled(bool value) { }

}

