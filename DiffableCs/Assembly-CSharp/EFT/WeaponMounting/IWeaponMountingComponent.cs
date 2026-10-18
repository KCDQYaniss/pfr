namespace EFT.WeaponMounting;

public interface IWeaponMountingComponent : IDisposable
{

	public IMountingPointDetectionSettings MountingPointDetectionSettings
	{
		 get { } //Length: 0
	}

	public Action OnNothingFound
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void CancelFindingPoint() { }

	public IMountingPointDetectionSettings get_MountingPointDetectionSettings() { }

	public Action get_OnNothingFound() { }

	public void set_OnNothingFound(Action value) { }

	public void TryMountWeapon(FirearmController controller) { }

}

