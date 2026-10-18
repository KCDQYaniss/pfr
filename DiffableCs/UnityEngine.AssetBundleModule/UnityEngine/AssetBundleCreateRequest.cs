namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation
{

	public AssetBundle assetBundle
	{
		[NativeMethod("GetAssetBundleBlocking")]
		 get { } //Length: 78
	}

	public AssetBundleCreateRequest() { }

	[NativeMethod("GetAssetBundleBlocking")]
	public AssetBundle get_assetBundle() { }

}

