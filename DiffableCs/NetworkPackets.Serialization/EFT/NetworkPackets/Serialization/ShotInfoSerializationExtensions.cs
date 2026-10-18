namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class ShotInfoSerializationExtensions
{
	private const float DAMAGE_EPSILON = 0.001953125; //Field offset: 0x0
	private const float PENETRATION_POWER_EPSILON = 0.001953125; //Field offset: 0x0
	public static readonly LimitedIntSerializationSettings TrajectoryLengthSettings; //Field offset: 0x0
	public static readonly LimitedFloatSerializationSettings DamageSerializationSettings; //Field offset: 0xC
	public static readonly LimitedFloatSerializationSettings StaminaBurnRateSerializationSettings; //Field offset: 0x1C
	public static readonly LimitedFloatSerializationSettings PenetrationPowerSerializationSettings; //Field offset: 0x2C
	public static readonly LimitedFloatSerializationSettings ArmorDamageSerializationSettings; //Field offset: 0x3C
	public static readonly LimitedFloatSerializationSettings HitCosSerializationSettings; //Field offset: 0x4C
	private static readonly int[] _shotsCountRanges; //Field offset: 0x60
	private static readonly ShotInfo _defaultShotInfo; //Field offset: 0x68

	private static ShotInfoSerializationExtensions() { }

	[Extension]
	public static void Serialize(IBitStream stream, ref OneAndList currentShotsForApprovement) { }

	[Extension]
	public static void SerializePrev(IBitStream stream, ref ShotInfo currentShot, ShotInfo prevShot) { }

}

