namespace EFT.Vaulting;

public interface IVaultingComponent
{

	public bool CanDamageLeftHand(EVaultingStrategy strategy) { }

	public bool CanDamageLegs(EVaultingStrategy strategy) { }

	public bool CanDamageRightHand(EVaultingStrategy strategy) { }

	public void DoVaultingTick() { }

	public bool TryVaulting() { }

}

