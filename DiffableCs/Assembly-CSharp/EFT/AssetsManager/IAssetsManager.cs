namespace EFT.AssetsManager;

public interface IAssetsManager
{

	public string[] Variants
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string[] get_Variants() { }

	public Object GetAsset(string assetName) { }

	public T GetAsset(string assetName) { }

	public string GetAssetName(ResourceKey resourceKey) { }

	public IOperation LoadAssetAsync(string bundleName, string assetName) { }

	public IOperation LoadAssetAsync(ResourceKey resourceKey) { }

	public IOperation LoadAssetsAsync(string bundleName) { }

	public IOperation LoadBundlesAsync(string[] resourceKeys) { }

	public IOperation LoadMainAssetAsync(string bundleName) { }

	public LoadSceneOperation LoadScene(string bundleName, string sceneName, LoadSceneMode loadSceneMode = 0, bool allowSceneActivation = true, Action progressCallback = null) { }

	public void set_Variants(string[] value) { }

	public void UnloadBundle(string prefubId, bool unloadAllLoadedObjects) { }

	public void UnloadBundleWithDependences(string assetName, bool unloadAllLoadedObjects) { }

	public void UnloadUnusedResources() { }

}

