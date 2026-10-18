namespace EFT.ProfileEditor.UI;

public class ProfileButton : UIElement
{
	[SerializeField]
	private DefaultUIButton _inventoryButton; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _dressRoomButton; //Field offset: 0x78
	private Action _onInventoryClick; //Field offset: 0x80
	private Action _onDressRoomClick; //Field offset: 0x88

	public ProfileButton() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	private void <Awake>b__4_1() { }

	private void Awake() { }

	public void Show(string profileName, Action onInventoryClick, Action onDressRoomClick) { }

}

