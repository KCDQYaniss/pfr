//Type is in global namespace

public class WeaponPreviewPool : MonoBehaviour
{
	[SerializeField]
	private WeaponPreview _weaponPreviewTemplate; //Field offset: 0x20
	[SerializeField]
	private int _count; //Field offset: 0x28
	private readonly List _availableWeaponPreviews; //Field offset: 0x30

	public WeaponPreviewPool() { }

	private void Awake() { }

	[CanBeNull]
	public WeaponPreview GetWeaponPreview() { }

	public void ReturnToPool(WeaponPreview weaponPreview) { }

}

