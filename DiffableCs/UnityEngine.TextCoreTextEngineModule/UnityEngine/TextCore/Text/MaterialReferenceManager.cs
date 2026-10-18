namespace UnityEngine.TextCore.Text;

internal class MaterialReferenceManager
{
	private static MaterialReferenceManager s_Instance; //Field offset: 0x0
	private Dictionary m_FontMaterialReferenceLookup; //Field offset: 0x10
	private Dictionary m_FontAssetReferenceLookup; //Field offset: 0x18
	private Dictionary m_SpriteAssetReferenceLookup; //Field offset: 0x20
	private Dictionary m_ColorGradientReferenceLookup; //Field offset: 0x28

	public static MaterialReferenceManager instance
	{
		 get { } //Length: 215
	}

	public MaterialReferenceManager() { }

	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	public static void AddFontAsset(FontAsset fontAsset) { }

	private void AddFontAssetInternal(FontAsset fontAsset) { }

	public static void AddFontMaterial(int hashCode, Material material) { }

	private void AddFontMaterialInternal(int hashCode, Material material) { }

	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	public static MaterialReferenceManager get_instance() { }

	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	public static bool TryGetMaterial(int hashCode, out Material material) { }

	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

}

