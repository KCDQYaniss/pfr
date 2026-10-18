namespace EFT.UI.Tutorial;

public class KeyBindingView : MonoBehaviour
{
	[SerializeField]
	private Transform _keyCombinationContainer; //Field offset: 0x20
	[SerializeField]
	private KeyView _keyView; //Field offset: 0x28
	[SerializeField]
	private CustomTextMeshProUGUI _keyBindingDescriptionText; //Field offset: 0x30

	public KeyBindingView() { }

	internal void Init(KeyBinding keyBinding) { }

}

