namespace EFT.UI;

[RequireComponent(typeof(BattleUIComponentAnimation))]
public sealed class AmmoCountPanel : UIElement
{
	private static readonly string[] _lvlZero; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _ammoCount; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _ammoDetails; //Field offset: 0x78
	private BattleUIComponentAnimation _animation; //Field offset: 0x80

	private static AmmoCountPanel() { }

	public AmmoCountPanel() { }

	public virtual void Close() { }

	public static string GetAmmoCountByLevel(int ammoCount, int maxAmmoCount, int level) { }

	public static string GetAmmoCountByLevelForFoldingMechanismWeapon(int ammoCount, int maxAmmoCount) { }

	public void Hide() { }

	public void Show(string message, string details = null) { }

	public void ShowFireMode(EFireMode fireMode) { }

}

