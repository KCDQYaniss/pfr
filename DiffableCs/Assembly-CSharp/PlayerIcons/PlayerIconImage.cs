namespace PlayerIcons;

public class PlayerIconImage
{
	[SerializeField]
	private Image _pmcPreview; //Field offset: 0x10
	[SerializeField]
	private GameObject _progress; //Field offset: 0x18
	private PlayerIconRequest _playerIconRequest; //Field offset: 0x20
	private ItemIcon _presetIcon; //Field offset: 0x28

	public PlayerIconImage() { }

	private void OnIconChange() { }

	public void SetPresetIcon(BodyCustomization customization, InventoryEquipment equipment) { }

	public void SetPresetIcon(Profile profile) { }

	public void SetPresetIcon(PlayerIconRequest iconRequest) { }

}

