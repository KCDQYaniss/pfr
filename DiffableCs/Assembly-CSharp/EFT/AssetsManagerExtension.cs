namespace EFT;

[Extension]
public static class AssetsManagerExtension
{

	[Extension]
	public static T Instantiate(IAssetsManager assetsManager, string assetName) { }

	[Extension]
	public static T Instantiate(IAssetsManager assetsManager, string assetName, Vector3 position, Quaternion rotation) { }

	[Extension]
	public static T Instantiate(IAssetsManager assetsManager, ResourceKey resourceKey) { }

	[Extension]
	public static T Instantiate(IAssetsManager assetsManager, ResourceKey resourceKey, Vector3 position, Quaternion rotation) { }

	[Extension]
	public static LoadSceneOperation LoadScene(IAssetsManager manager, ResourceKey resourceKey, LoadSceneMode loadSceneMode = 0, bool allowSceneActivation = true, Action progressCallback = null) { }

	[Extension]
	public static IOperation LoadSceneByReference(IAssetsManager manager, string reference, LoadSceneMode loadSceneMode = 0, bool allowSceneActivation = true, Action progressCallback = null) { }

	[Extension]
	public static LoadScenesFromPresetOperation LoadScenesFromPreset(IAssetsManager assetsManager, ScenePresetLoadConfig preset, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = null, IProgress progress = null) { }

	[Extension]
	public static LoadScenesFromPresetOperation LoadScenesFromPreset(IAssetsManager assetsManager, ScenesPreset preset, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = null) { }

	private static ResourceKey ReferenceToResourceKey(string reference) { }

}

