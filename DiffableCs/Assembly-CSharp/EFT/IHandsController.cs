namespace EFT;

public interface IHandsController
{

	public float AimingSensitivity
	{
		 get { } //Length: 0
	}

	public bool Destroyed
	{
		 get { } //Length: 0
	}

	public FirearmsAnimator FirearmsAnimator
	{
		 get { } //Length: 0
	}

	public TransformLinks HandsHierarchy
	{
		 get { } //Length: 0
	}

	public bool IsAiming
	{
		 get { } //Length: 0
	}

	public Item Item
	{
		 get { } //Length: 0
	}

	public void BlindFire(int b) { }

	public bool CanExecute(IInventoryOperation operation) { }

	public bool CanInteract() { }

	public bool CanRemove() { }

	public void Destroy() { }

	public void Execute(IInventoryOperation operation, Callback callback) { }

	public float get_AimingSensitivity() { }

	public bool get_Destroyed() { }

	public FirearmsAnimator get_FirearmsAnimator() { }

	public TransformLinks get_HandsHierarchy() { }

	public bool get_IsAiming() { }

	public Item get_Item() { }

	public float GetAnimatorFloatParam(int hash) { }

	public bool InCanNotBeInterruptedOperation() { }

	public void Interact(bool isInteracting, int actionIndex) { }

	public bool IsHandsProcessing() { }

	public bool IsInInteraction() { }

	public bool IsInInteractionStrictCheck() { }

	public bool IsPlacingBeacon() { }

	public void Loot(bool b) { }

	public void ManualLateUpdate(float deltaTime) { }

	public void OnGameSessionEnd() { }

	public void OnPlayerDead() { }

	public void Pickup(bool p) { }

	public void SetInventoryOpened(bool opened) { }

	public void ShowGesture(EInteraction gesture) { }

	public bool SupportPickup() { }

}

