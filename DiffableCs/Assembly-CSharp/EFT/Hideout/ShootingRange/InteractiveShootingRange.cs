namespace EFT.Hideout.ShootingRange;

public abstract class InteractiveShootingRange : InteractableObject
{
	protected bool _enabled; //Field offset: 0x48

	protected InteractiveShootingRange() { }

	public override void Disable() { }

	public override void Enable() { }

	public override AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

}

