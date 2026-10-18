namespace EFT.AssetsManager;

[DisallowMultipleComponent]
public class WeaponModPoolObject : AssetPoolObject
{
	private OpticSight[] _opticSights; //Field offset: 0x90

	public WeaponModPoolObject() { }

	public virtual void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	protected virtual void ReturnToPool() { }

}

