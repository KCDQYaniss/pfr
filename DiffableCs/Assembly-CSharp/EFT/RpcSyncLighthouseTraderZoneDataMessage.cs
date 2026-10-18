namespace EFT;

public sealed class RpcSyncLighthouseTraderZoneDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private LighthouseTraderZoneData <Data>k__BackingField; //Field offset: 0x10

	public LighthouseTraderZoneData Data
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcSyncLighthouseTraderZoneDataMessage() { }

	public RpcSyncLighthouseTraderZoneDataMessage(LighthouseTraderZoneData data) { }

	public override void Deserialize(NetworkReader reader) { }

	public LighthouseTraderZonePlayerData DeserializeLighthouse(NetworkReader reader) { }

	[CompilerGenerated]
	public LighthouseTraderZoneData get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	public void SerializeLighthouse(NetworkWriter writer, LighthouseTraderZonePlayerData lighthouseTraderZonePlayerData) { }

	[CompilerGenerated]
	public void set_Data(LighthouseTraderZoneData value) { }

}

