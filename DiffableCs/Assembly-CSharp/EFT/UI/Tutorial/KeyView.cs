namespace EFT.UI.Tutorial;

public class KeyView : MonoBehaviour
{
	[SerializeField]
	private Image _keyImage; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _keyText; //Field offset: 0x28

	public KeyView() { }

	internal void Init(Key key) { }

	private void SetKeyImage(Sprite imageSprite) { }

	private void SetKeyText(string text) { }

}

