namespace EFT;

public sealed class VaultSettings : IVaultSettings, IBaseMoveSettings
{
	[JsonProperty("IsActive")]
	public readonly bool IsActive; //Field offset: 0x10
	[JsonProperty("MaxWithoutHandHeight")]
	public readonly float MaxWithoutHandHeight; //Field offset: 0x14
	[JsonProperty("SpeedRange")]
	public readonly Vector2 SpeedRange; //Field offset: 0x18
	[JsonProperty("MoveRestrictions")]
	public readonly MoveRestrictions MoveRestrictions; //Field offset: 0x20
	[JsonProperty("AutoMoveRestrictions")]
	public readonly AutoMoveRestrictions AutoMoveRestrictions; //Field offset: 0x28

	private override IAutoMoveRestrictions EFT.Vaulting.IBaseMoveSettings.AutoMoveRestrictions
	{
		private get { } //Length: 5
	}

	private override bool EFT.Vaulting.IBaseMoveSettings.IsActive
	{
		private get { } //Length: 5
	}

	private override float EFT.Vaulting.IBaseMoveSettings.MaxWithoutHandHeight
	{
		private get { } //Length: 6
	}

	private override IMoveRestrictions EFT.Vaulting.IBaseMoveSettings.MoveRestrictions
	{
		private get { } //Length: 5
	}

	public VaultSettings() { }

	private override IAutoMoveRestrictions EFT.Vaulting.IBaseMoveSettings.get_AutoMoveRestrictions() { }

	private override bool EFT.Vaulting.IBaseMoveSettings.get_IsActive() { }

	private override float EFT.Vaulting.IBaseMoveSettings.get_MaxWithoutHandHeight() { }

	private override IMoveRestrictions EFT.Vaulting.IBaseMoveSettings.get_MoveRestrictions() { }

}

