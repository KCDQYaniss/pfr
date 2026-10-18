namespace EFT.UI.Tutorial;

public class KeyBindingBannerView : MonoBehaviour
{
	public Transform VerticalLayoutTransform; //Field offset: 0x20
	[SerializeField]
	private KeyBindingView _keyBindingView; //Field offset: 0x28
	private readonly int _keysPerVerticalPanel; //Field offset: 0x30

	public KeyBindingBannerView() { }

	internal void Init(KeyBinding[] keyBindings) { }

}

