namespace EFT.NextObservedPlayer;

public sealed class SkillsParamsCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public float CovertMovementSpeed; //Field offset: 0x10
	public float CovertMovementHardSurfaceReduction; //Field offset: 0x14
	public float CovertMovementSoftSurfaceReduction; //Field offset: 0x18
	public float CovertMovementEquipment; //Field offset: 0x1C
	public float BotSoundCoef; //Field offset: 0x20
	public bool HeavyVestNoBodyDamageDeflectChance; //Field offset: 0x24
	public float WeaponDurabilityLosOnShotReduce; //Field offset: 0x28
	public float AimingVolumeReduction; //Field offset: 0x2C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SkillsParamsCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SkillsParamsCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

