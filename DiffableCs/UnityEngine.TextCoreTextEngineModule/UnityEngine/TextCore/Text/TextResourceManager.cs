namespace UnityEngine.TextCore.Text;

internal class TextResourceManager
{
	private struct FontAssetRef
	{
		public int nameHashCode; //Field offset: 0x0
		public int familyNameHashCode; //Field offset: 0x4
		public int styleNameHashCode; //Field offset: 0x8
		public long familyNameAndStyleHashCode; //Field offset: 0x10
		public readonly FontAsset fontAsset; //Field offset: 0x18

		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }

	}

	private static readonly Dictionary s_FontAssetReferences; //Field offset: 0x0
	private static readonly Dictionary s_FontAssetNameReferenceLookup; //Field offset: 0x8
	private static readonly Dictionary s_FontAssetFamilyNameAndStyleReferenceLookup; //Field offset: 0x10
	private static readonly List s_FontAssetRemovalList; //Field offset: 0x18
	private static readonly int k_RegularStyleHashCode; //Field offset: 0x20

	private static TextResourceManager() { }

	internal static void AddFontAsset(FontAsset fontAsset) { }

}

