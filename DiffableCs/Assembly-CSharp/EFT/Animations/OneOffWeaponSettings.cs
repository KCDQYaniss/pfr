namespace EFT.Animations;

public class OneOffWeaponSettings : MonoBehaviour
{
	[SerializeField]
	private GameObject _ammo; //Field offset: 0x20
	[SerializeField]
	private bool _canAim; //Field offset: 0x28

	public bool CanAim
	{
		 get { } //Length: 5
	}

	public GameObject SpawneAmmo
	{
		 get { } //Length: 5
	}

	public OneOffWeaponSettings() { }

	public bool get_CanAim() { }

	public GameObject get_SpawneAmmo() { }

}

