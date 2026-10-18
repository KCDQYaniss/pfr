namespace EFT.NextObservedPlayer;

public class BreakMeleeComboCombatMessage : ICommandMessage, ISerializableMessage, IDisposable
{

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public BreakMeleeComboCombatMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static BreakMeleeComboCombatMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

