namespace EFT.NextObservedPlayer;

public class SpectatorBlindnessCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	internal struct BurnEyesEntry
	{
		public Vector3 Position; //Field offset: 0x0
		public float DistanceStrength; //Field offset: 0xC
		public float ElapsedTime; //Field offset: 0x10
		public bool HasScreenUv; //Field offset: 0x14
		public Vector2 ScreenUv; //Field offset: 0x18

	}

	internal struct StunEntry
	{
		public int EffectId; //Field offset: 0x0
		public float Strength; //Field offset: 0x4
		public float BuildUpTime; //Field offset: 0x8
		public float WorkTime; //Field offset: 0xC
		public float WholeTime; //Field offset: 0x10

	}

	public BurnEyesEntry[] Burns; //Field offset: 0x10
	public StunEntry[] Stuns; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorBlindnessCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SpectatorBlindnessCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

