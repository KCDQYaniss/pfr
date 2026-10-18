namespace EFT;

public sealed class VaultingGlobalSettings : IVaultingSettings
{
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <VaultingInputTime>k__BackingField; //Field offset: 0x14
	[JsonProperty("GridSettings")]
	public readonly GridSettings GridSettings; //Field offset: 0x18
	[JsonProperty("MovesSettings")]
	public readonly MovesSettings MovesSettings; //Field offset: 0x20

	private override IGridSettings EFT.Vaulting.IVaultingSettings.GridSettings
	{
		private get { } //Length: 5
	}

	private override bool EFT.Vaulting.IVaultingSettings.IsActive
	{
		private get { } //Length: 5
	}

	private override IMovesSettings EFT.Vaulting.IVaultingSettings.MovesSettings
	{
		private get { } //Length: 5
	}

	private override float EFT.Vaulting.IVaultingSettings.VaultingInputTime
	{
		private get { } //Length: 6
	}

	[JsonProperty("IsActive")]
	public bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonProperty("VaultingInputTime")]
	public float VaultingInputTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public VaultingGlobalSettings() { }

	private override IGridSettings EFT.Vaulting.IVaultingSettings.get_GridSettings() { }

	private override bool EFT.Vaulting.IVaultingSettings.get_IsActive() { }

	private override IMovesSettings EFT.Vaulting.IVaultingSettings.get_MovesSettings() { }

	private override float EFT.Vaulting.IVaultingSettings.get_VaultingInputTime() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public float get_VaultingInputTime() { }

	[CompilerGenerated]
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	public void set_VaultingInputTime(float value) { }

}

