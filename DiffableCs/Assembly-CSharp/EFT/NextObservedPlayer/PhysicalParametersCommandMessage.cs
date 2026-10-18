namespace EFT.NextObservedPlayer;

public class PhysicalParametersCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public float Overweight; //Field offset: 0x10
	public float TransitionSpeed; //Field offset: 0x14
	public bool IsHeavyBreathing; //Field offset: 0x18
	public float WalkOverweight; //Field offset: 0x1C
	public float SoundRadius; //Field offset: 0x20
	public bool BreathIsAudible; //Field offset: 0x24
	public float MinStepSound; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public PhysicalParametersCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static PhysicalParametersCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

