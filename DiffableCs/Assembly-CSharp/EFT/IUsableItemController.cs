namespace EFT;

public interface IUsableItemController : IWeaponController, IHandsController, ICompassController
{

	public bool ExamineWeapon() { }

	public void Hide() { }

	public void SetAim(bool value) { }

	public void ToggleAim() { }

}

