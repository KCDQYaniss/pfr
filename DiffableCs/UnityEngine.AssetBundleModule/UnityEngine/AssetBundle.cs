namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
public class AssetBundle : Object
{

	[Obsolete("mainAsset has been made obsolete. Please use the new AssetBundle build system introduced in 5.0 and check BuildAssetBundles documentation for details.")]
	public Object mainAsset
	{
		 get { } //Length: 78
	}

	private AssetBundle() { }

	public Object get_mainAsset() { }

	[NativeMethod("GetAllAssetNames")]
	public string[] GetAllAssetNames() { }

	public Object[] LoadAllAssets(Type type) { }

	public Object[] LoadAllAssets() { }

	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	public AssetBundleRequest LoadAllAssetsAsync() { }

	public Object LoadAsset(string name) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	public Object LoadAsset(string name, Type type) { }

	[NativeMethod("LoadAsset_Internal")]
	[NativeThrows]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	[NativeMethod("LoadAssetAsync_Internal")]
	[NativeThrows]
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethod("LoadAssetWithSubAssets_Internal")]
	[NativeThrows]
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
	[NativeThrows]
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunction("LoadFromFileAsync")]
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	[FreeFunction("LoadMainObjectFromAssetBundle", True)]
	internal static Object returnMainAsset(AssetBundle bundle) { }

	[NativeMethod("Unload")]
	[NativeThrows]
	public void Unload(bool unloadAllLoadedObjects) { }

}

