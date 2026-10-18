namespace EFT;

public abstract class AbstractGameSession : AbstractSession
{
	public sealed class AcceptReject : ISerializableMessage
	{
		internal const int LOCATION_MISMATCH_ERROR_CODE = 100500; //Field offset: 0x0
		internal const int INVALID_PROFILE_ERROR_CODE = 100501; //Field offset: 0x0
		internal const int INVALID_PROFILE_TOKEN_ERROR_CODE = 100502; //Field offset: 0x0
		internal const int CLIENT_MESSAGING_QUEUE_ERROR_CODE = 100503; //Field offset: 0x0
		internal int ErrorCode; //Field offset: 0x10

		public AcceptReject() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class AcceptRequest : ISerializableMessage
	{
		internal string ProfileId; //Field offset: 0x10
		internal string Token; //Field offset: 0x18
		internal bool ObserveOnly; //Field offset: 0x20
		internal byte[] OpenEncryptionKey; //Field offset: 0x28
		internal int OpenEncryptionKeyLength; //Field offset: 0x30
		internal string LocationId; //Field offset: 0x38

		public AcceptRequest() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class AcceptResponse : ISerializableMessage
	{
		internal bool EncryptionEnabled; //Field offset: 0x10
		internal bool DecryptionEnabled; //Field offset: 0x11
		internal GameDateTime GameDateTime; //Field offset: 0x18
		internal byte[] Prefabs; //Field offset: 0x20
		internal byte[] Customizations; //Field offset: 0x28
		internal byte[] Weather; //Field offset: 0x30
		internal ESeason Season; //Field offset: 0x38
		internal SeasonsSettings SeasonsSettings; //Field offset: 0x40
		internal bool CanRespawn; //Field offset: 0x48
		internal EMemberCategory MemberCategory; //Field offset: 0x4C
		internal float FixedDeltaTime; //Field offset: 0x50
		internal byte[] Interactables; //Field offset: 0x58
		internal byte[] AnticheatSession; //Field offset: 0x60
		internal Bounds PositionQuantizer; //Field offset: 0x68
		internal ushort SaberServerAnticheatPort; //Field offset: 0x80
		internal ENetLogsLevel LogsLevel; //Field offset: 0x84
		internal GitVersion GitVersion; //Field offset: 0x88
		internal bool SpeedLimitsEnabled; //Field offset: 0x90
		internal Config SpeedLimits; //Field offset: 0x98
		internal VoipSettings VoipSettings; //Field offset: 0xA0

		public AcceptResponse() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class BattlEyeAnticheatPacket : ISerializableMessage
	{
		internal byte[] Packet; //Field offset: 0x10

		public BattlEyeAnticheatPacket() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class ProfileResources : ISerializableMessage
	{
		internal int Id; //Field offset: 0x10
		internal byte[] Resources; //Field offset: 0x18
		internal byte[] Customization; //Field offset: 0x20

		public ProfileResources() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class ProgressReport : ISerializableMessage
	{
		internal string SessionId; //Field offset: 0x10
		internal int Id; //Field offset: 0x18
		internal float Progress; //Field offset: 0x1C

		public ProgressReport() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class TotalProgressReport : ISerializableMessage
	{
		internal float Progress; //Field offset: 0x10

		public TotalProgressReport() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class TraceMessage : TraceMessageBase
	{
		public string Message; //Field offset: 0x20

		public TraceMessage() { }

		public void Deserialize(NetworkReader reader) { }

		public void Serialize(NetworkWriter writer) { }

	}

	public class TraceMessageBase : ISerializableMessage
	{
		public byte TracerId; //Field offset: 0x10
		public string[] Context; //Field offset: 0x18

		public TraceMessageBase() { }

		public override void Deserialize(NetworkReader reader) { }

		public override void Serialize(NetworkWriter writer) { }

	}

	public sealed class TraceMessageWithCode : TraceMessageBase
	{
		public ETraceCode Code; //Field offset: 0x20

		public TraceMessageWithCode() { }

		public void Deserialize(NetworkReader reader) { }

		public void Serialize(NetworkWriter writer) { }

	}


	protected AbstractGameSession() { }

	protected static T Create(Transform parent, string name, string profileId, string token) { }

}

