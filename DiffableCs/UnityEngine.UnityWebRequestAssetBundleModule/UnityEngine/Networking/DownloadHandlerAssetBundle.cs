namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler
{

	public AssetBundle assetBundle
	{
		 get { } //Length: 78
	}

	public DownloadHandlerAssetBundle(string url, uint crc) { }

	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	public AssetBundle get_assetBundle() { }

	public static AssetBundle GetContent(UnityWebRequest www) { }

	protected virtual byte[] GetData() { }

	protected virtual string GetText() { }

	private void InternalCreateAssetBundle(string url, uint crc) { }

}

