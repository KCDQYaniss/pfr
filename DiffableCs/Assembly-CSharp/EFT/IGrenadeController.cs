namespace EFT;

public interface IGrenadeController : IWeaponController, IHandsController, ICompassController
{

	public EFireMode CurrentFireMode
	{
		 get { } //Length: 0
	}

	public ThrowWeap Item
	{
		 get { } //Length: 0
	}

	public bool WaitingForHighThrow
	{
		 get { } //Length: 0
	}

	public bool WaitingForLowThrow
	{
		 get { } //Length: 0
	}

	public bool CanChangeFireMode(EFireMode fireMode) { }

	public bool CanThrow() { }

	public void ChangeFireMode(EFireMode fireMode) { }

	public void ExamineWeapon() { }

	public EFireMode get_CurrentFireMode() { }

	public ThrowWeap get_Item() { }

	public bool get_WaitingForHighThrow() { }

	public bool get_WaitingForLowThrow() { }

	public void HandleAltFireInput() { }

	public void HandleFireInput() { }

	public void HighThrow() { }

	public void LowThrow() { }

	public void PullRingForHighThrow() { }

	public void PullRingForLowThrow() { }

	public void SetOnUsedCallback(Callback callback) { }

}

