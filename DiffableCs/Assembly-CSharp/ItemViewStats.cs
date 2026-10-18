//Type is in global namespace

public class ItemViewStats : MonoBehaviour
{
	[SerializeField]
	private Image _modIcon; //Field offset: 0x20
	[SerializeField]
	private Image _modTypeIcon; //Field offset: 0x28
	[SerializeField]
	private Image _specialIcon; //Field offset: 0x30
	[SerializeField]
	private Image _armorClassIcon; //Field offset: 0x38
	[SerializeField]
	private GameObject _modTypeIconParent; //Field offset: 0x40

	public ItemViewStats() { }

	private static string GetArmorPlateClassIconName(ArmorPlate item) { }

	private bool IsMoveAblePlate(ArmorPlate plate) { }

	private void SetArmorPlateIcon(ArmorPlate armorPlate, bool examined) { }

	private void SetItemIcon(Item item, bool examined) { }

	public void SetStaticInfo(Item item, bool examined) { }

}

