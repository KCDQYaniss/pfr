namespace TMPro;

public class TMP_ResourceManager
{
	private static readonly TMP_ResourceManager s_instance; //Field offset: 0x0
	private static TMP_Settings s_TextSettings; //Field offset: 0x8
	private static readonly List s_FontAssetReferences; //Field offset: 0x10
	private static readonly Dictionary s_FontAssetReferenceLookup; //Field offset: 0x18

	private static TMP_ResourceManager() { }

	public TMP_ResourceManager() { }

	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	internal static TMP_Settings GetTextSettings() { }

	internal static void RebuildFontAssetCache(int instanceID) { }

	public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) { }

}

