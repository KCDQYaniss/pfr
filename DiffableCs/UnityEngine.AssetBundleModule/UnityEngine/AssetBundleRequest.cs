namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRequest : ResourceRequest
{

	public Object[] allAssets
	{
		[NativeMethod("GetAllLoadedAssets")]
		 get { } //Length: 78
	}

	public Object asset
	{
		 get { } //Length: 20
	}

	public AssetBundleRequest() { }

	[NativeMethod("GetAllLoadedAssets")]
	public Object[] get_allAssets() { }

	public Object get_asset() { }

	[NativeMethod("GetLoadedAsset")]
	protected virtual Object GetResult() { }

}

