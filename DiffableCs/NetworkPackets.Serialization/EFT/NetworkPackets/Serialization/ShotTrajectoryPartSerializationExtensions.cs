namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class ShotTrajectoryPartSerializationExtensions
{
	public static readonly LimitedFloatSerializationSettings BulletMassGramSettings; //Field offset: 0x0
	public static readonly LimitedFloatSerializationSettings BulletDiameterMillimetersSettings; //Field offset: 0x10
	public static readonly LimitedFloatSerializationSettings BallisticCoefficientSettings; //Field offset: 0x20
	public static readonly LimitedFloatSerializationSettings DurationSettings; //Field offset: 0x30

	private static ShotTrajectoryPartSerializationExtensions() { }

	[Extension]
	public static void Serialize(IBitStream stream, ref ShotTrajectoryPart shotTrajectoryPart) { }

}

