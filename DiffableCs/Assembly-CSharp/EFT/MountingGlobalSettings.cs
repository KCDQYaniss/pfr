namespace EFT;

public sealed class MountingGlobalSettings
{
	[JsonProperty("PointDetectionSettings")]
	public MountingPointDetectionSettings PointDetectionSettings; //Field offset: 0x10
	[JsonProperty("MovementSettings")]
	public MountingMovementSettings MovementSettings; //Field offset: 0x18

	public MountingGlobalSettings() { }

}

