namespace EFT.Hideout;

public class ShootingRangeBehaviour : AreaBehaviour
{
	private HideoutPlayerOwner _playerOwner; //Field offset: 0x68

	public ShootingRangeBehaviour() { }

	public virtual void BehaviourUpdate() { }

	public void ManualEnterLocation(HideoutPlayerOwner player) { }

	public virtual void OnExitLocation() { }

}

