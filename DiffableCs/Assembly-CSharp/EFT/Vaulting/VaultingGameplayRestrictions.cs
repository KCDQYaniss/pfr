namespace EFT.Vaulting;

public class VaultingGameplayRestrictions : IVaultingGameplayRestrictions
{
	private readonly Player _player; //Field offset: 0x10
	private readonly IVaultingParameters _vaultingParameters; //Field offset: 0x18
	private readonly IVaultingSettings _vaultingSettings; //Field offset: 0x20
	private EVaultingStrategy _currentStrategy; //Field offset: 0x28

	private float maxClimbWithoutHandsHeight
	{
		private get { } //Length: 162
	}

	private float maxVaultWithoutHandsHeight
	{
		private get { } //Length: 159
	}

	public VaultingGameplayRestrictions(Player player, IVaultingParameters parameters) { }

	private void CalculateStrategy() { }

	public override bool CanVaulting() { }

	private bool CheckBlindFireCondition() { }

	private bool CheckGrenadeOperation() { }

	private bool CheckInventoryOperations() { }

	private bool CheckMedsAndFoodOperation() { }

	private bool CheckPoseLevelCondition() { }

	private bool CheckWeaponOperation() { }

	private float get_maxClimbWithoutHandsHeight() { }

	private float get_maxVaultWithoutHandsHeight() { }

}

