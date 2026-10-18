namespace EFT.UI;

public sealed class UIPointer : MonoBehaviour
{
	public Image Image; //Field offset: 0x20
	public Sprite HoverSprite; //Field offset: 0x28
	public Sprite UnavailableSprite; //Field offset: 0x30
	public Sprite SenseSprite; //Field offset: 0x38

	public UIPointer() { }

}

