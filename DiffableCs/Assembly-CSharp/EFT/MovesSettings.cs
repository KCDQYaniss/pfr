namespace EFT;

public sealed class MovesSettings : IMovesSettings
{
	[JsonProperty("VaultSettings")]
	public readonly VaultSettings VaultSettings; //Field offset: 0x10
	[JsonProperty("ClimbSettings")]
	public readonly ClimbSettings ClimbSettings; //Field offset: 0x18

	private override IClimbSettings EFT.Vaulting.IMovesSettings.ClimbSettings
	{
		private get { } //Length: 5
	}

	private override IVaultSettings EFT.Vaulting.IMovesSettings.VaultSettings
	{
		private get { } //Length: 5
	}

	public MovesSettings() { }

	private override IClimbSettings EFT.Vaulting.IMovesSettings.get_ClimbSettings() { }

	private override IVaultSettings EFT.Vaulting.IMovesSettings.get_VaultSettings() { }

}

