namespace EFT.NextObservedPlayer;

public sealed class SpectatorScopeZoomStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	internal enum EChangeType
	{
		Discrete = 0,
		Smooth = 1,
	}

	public string SightId; //Field offset: 0x10
	public EChangeType ChangeType; //Field offset: 0x18
	public int ScopeMode; //Field offset: 0x1C
	public int ScopeIndexInsideSight; //Field offset: 0x20
	public int ScopeCalibrationIndex; //Field offset: 0x24
	public float ScopeZoomValue; //Field offset: 0x28
	public float InterpolationDuration; //Field offset: 0x2C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorScopeZoomStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SpectatorScopeZoomStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

