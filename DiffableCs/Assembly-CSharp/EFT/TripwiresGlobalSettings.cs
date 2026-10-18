namespace EFT;

public sealed class TripwiresGlobalSettings
{
	[JsonProperty("ShotSqrDistance")]
	public float ShotSqrDistance; //Field offset: 0x10
	[JsonProperty("InteractionSqrDistance")]
	public float InteractionSqrDistance; //Field offset: 0x14
	[JsonProperty("MaxHeightDifference")]
	public float MaxHeightDifference; //Field offset: 0x18
	[JsonProperty("MinLength")]
	public float MinLength; //Field offset: 0x1C
	[JsonProperty("MaxLength")]
	public float MaxLength; //Field offset: 0x20
	[JsonProperty("MaxPreviewLength")]
	public float MaxPreviewLength; //Field offset: 0x24
	[JsonProperty("MaxTripwireToPlayerDistance")]
	public double MaxTripwireToPlayerDistance; //Field offset: 0x28
	[JsonProperty("CollisionCapsuleRadius")]
	public float CollisionCapsuleRadius; //Field offset: 0x30
	[JsonProperty("CollisionCapsuleCheckCoef")]
	public float CollisionCapsuleCheckCoef; //Field offset: 0x34
	[JsonProperty("GroundDotProductTolerance")]
	public double GroundDotProductTolerance; //Field offset: 0x38
	[JsonProperty("DefuseTimeSeconds")]
	public float DefuseTimeSeconds; //Field offset: 0x40
	[JsonProperty("MultitoolDefuseTimeSeconds")]
	public float MultitoolDefuseTimeSeconds; //Field offset: 0x44
	[JsonProperty("InertSeconds")]
	public int InertSeconds; //Field offset: 0x48
	[JsonProperty("DestroyedSeconds")]
	public int DestroyedSeconds; //Field offset: 0x4C

	public TripwiresGlobalSettings() { }

}

