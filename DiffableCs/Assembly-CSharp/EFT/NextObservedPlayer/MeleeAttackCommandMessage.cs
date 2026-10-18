namespace EFT.NextObservedPlayer;

public class MeleeAttackCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool Fire; //Field offset: 0x10
	public bool AltFire; //Field offset: 0x11
	public bool QuickFire; //Field offset: 0x12
	public float MeleeAttackSpeed; //Field offset: 0x14
	public Action ActionOnFireBullet; //Field offset: 0x18
	public Action ActionOnFireEnd; //Field offset: 0x20

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public MeleeAttackCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

