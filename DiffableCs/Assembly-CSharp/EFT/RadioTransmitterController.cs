namespace EFT;

internal class RadioTransmitterController : UsableItemController
{
	internal class RadioTransmitterDropBackpack : DropBackpackOperation
	{

		public RadioTransmitterDropBackpack(RadioTransmitterController controller) { }

		protected virtual void InitiateIdlingOperation() { }

		public virtual void SetAiming(bool isAiming) { }

	}

	public class RadioTransmitterIdling : Idling
	{

		public RadioTransmitterIdling(RadioTransmitterController controller) { }

		public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

		protected virtual void InitiateDropBackpackOperation(IOneItemOperation oneItemOperation, Callback callback) { }

		public virtual void SetAiming(bool isAiming) { }

	}

	internal class RadioTransmitterRemove : Remove
	{

		public RadioTransmitterRemove(RadioTransmitterController controller) { }

	}

	internal class RadioTransmitterSpawn : SpawnOperation
	{

		public RadioTransmitterSpawn(RadioTransmitterController controller) { }

		protected virtual void SetIdlingOperation() { }

		protected virtual void SetLeftStanceAnimOnStartOperation() { }

	}

	internal sealed class ServerRadioTransmitterDropBackpackOperation : ServerDropBackpackOperation
	{

		public ServerRadioTransmitterDropBackpackOperation(RadioTransmitterController controller) { }

	}

	private RadioTransmitterView _radioTransmitterView; //Field offset: 0xE0

	public RadioTransmitterController() { }

	protected virtual void InitializeController(Player player, WeaponPrefab weaponPrefab) { }

	public virtual void SetAim(bool value) { }

	protected virtual void StateChangedHandler(EPlayerState previousstate, EPlayerState nextstate) { }

}

