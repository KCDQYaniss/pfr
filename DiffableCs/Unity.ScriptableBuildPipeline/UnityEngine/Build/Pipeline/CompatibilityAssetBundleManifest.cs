namespace UnityEngine.Build.Pipeline;

public class CompatibilityAssetBundleManifest : ScriptableObject, ISerializationCallbackReceiver
{
	private Dictionary m_Details; //Field offset: 0x18
	[SerializeField]
	private List m_Keys; //Field offset: 0x20
	[SerializeField]
	private List m_Values; //Field offset: 0x28

	public CompatibilityAssetBundleManifest() { }

	public string[] GetAllAssetBundles() { }

	public string[] GetAllAssetBundlesWithVariant() { }

	public string[] GetAllDependencies(string assetBundleName) { }

	public uint GetAssetBundleCrc(string assetBundleName) { }

	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	public string[] GetDirectDependencies(string assetBundleName) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void SetResults(Dictionary results) { }

	public virtual string ToString() { }

}

