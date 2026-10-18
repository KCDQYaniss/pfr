namespace EFT;

public sealed class ClimbSettings : IClimbSettings, IBaseMoveSettings
{
	[JsonProperty("IsActive")]
	public readonly bool IsActive; //Field offset: 0x10
	[JsonProperty("MaxWithoutHandHeight")]
	public readonly float MaxWithoutHandHeight; //Field offset: 0x14
	[JsonProperty("MaxOneHandHeight")]
	public readonly float MaxOneHandHeight; //Field offset: 0x18
	[JsonProperty("SpeedRange")]
	public readonly Vector2 SpeedRange; //Field offset: 0x1C
	[JsonProperty("MoveRestrictions")]
	public MoveRestrictions MoveRestrictions; //Field offset: 0x28
	[JsonProperty("AutoMoveRestrictions")]
	public AutoMoveRestrictions AutoMoveRestrictions; //Field offset: 0x30

	private override IAutoMoveRestrictions EFT.Vaulting.IBaseMoveSettings.AutoMoveRestrictions
	{
		private get { } //Length: 76
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

	private override float EFT.Vaulting.IClimbSettings.MaxOneHandHeight
	{
		private get { } //Length: 6
	}

	public ClimbSettings() { }

	private override IAutoMoveRestrictions EFT.Vaulting.IBaseMoveSettings.get_AutoMoveRestrictions() { }

	private override bool EFT.Vaulting.IBaseMoveSettings.get_IsActive() { }

	private override float EFT.Vaulting.IBaseMoveSettings.get_MaxWithoutHandHeight() { }

	private override IMoveRestrictions EFT.Vaulting.IBaseMoveSettings.get_MoveRestrictions() { }

	private override float EFT.Vaulting.IClimbSettings.get_MaxOneHandHeight() { }

}

