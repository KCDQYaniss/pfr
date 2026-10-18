namespace EFT.UI.Tutorial;

public class KeyBannerGenerator : MonoBehaviour
{
	public KeyViewContentGenerator _generator; //Field offset: 0x20
	public KeyBanner[] Banners; //Field offset: 0x28
	public KeyBindingBannerView KeyBindingBannerView; //Field offset: 0x30

	public KeyBannerGenerator() { }

	public KeyBindingBannerView GetKeyBindingBanner(Transform container) { }

}

