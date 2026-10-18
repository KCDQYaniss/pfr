namespace EFT.NextObservedPlayer;

public sealed class SetHandsCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public static SetHandsCommandMessage EmptyHandsCommand; //Field offset: 0x0
	public EHandsControllerType HandControllerType; //Field offset: 0x10
	[Nullable]
	public ItemDescriptor Item; //Field offset: 0x18
	public bool FastHide; //Field offset: 0x20
	public EMalfunctionState MalfunctionState; //Field offset: 0x24
	public string MalfunctionedAmmo; //Field offset: 0x28
	public bool Armed; //Field offset: 0x30
	public int AmmoInChamber; //Field offset: 0x34
	public float DrawAnimationSpeedMultiplier; //Field offset: 0x38
	public float ReloadSpeed; //Field offset: 0x3C
	public bool BipodActive; //Field offset: 0x40
	public bool InsertTape; //Field offset: 0x41
	public bool EjectTape; //Field offset: 0x42
	public float AnimatorSpeed; //Field offset: 0x44

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	private static SetHandsCommandMessage() { }

	public SetHandsCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

