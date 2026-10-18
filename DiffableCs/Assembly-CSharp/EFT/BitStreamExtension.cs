namespace EFT;

[Extension]
public static class BitStreamExtension
{
	[CompilerGenerated]
	private static class <>O
	{
		public static SerializeDelegate <0>__SerializePacket; //Field offset: 0x0
		public static DeserializeDelegate <1>__DeserializeAcceptHitDebugDataPacket; //Field offset: 0x8
		public static SerializeDelegate <2>__SerializePacket; //Field offset: 0x10
		public static DeserializeDelegate <3>__DeserializeConditionValueChangedPacket; //Field offset: 0x18
		public static SerializeDelegate <4>__SerializePacket; //Field offset: 0x20
		public static DeserializeDelegate <5>__DeserializeShowStatNotificationPacket; //Field offset: 0x28
		public static SerializeDelegate <6>__SerializePacket; //Field offset: 0x30
		public static DeserializeDelegate <7>__DeserializeClientConfirmCallbackPacket; //Field offset: 0x38
		public static SerializeDelegate <8>__SerializePacket; //Field offset: 0x40
		public static DeserializeDelegate <9>__DeserializeTriggeredPerkPacket; //Field offset: 0x48
		public static SerializeDelegate <10>__SerializePacket; //Field offset: 0x50
		public static DeserializeDelegate <11>__DeserializeKeyUsagePacket; //Field offset: 0x58
		public static SerializeDelegate <12>__SerializePacket; //Field offset: 0x60
		public static DeserializeDelegate <13>__DeserializeChangeSkillExperiencePacket; //Field offset: 0x68
		public static SerializeDelegate <14>__SerializePacket; //Field offset: 0x70
		public static DeserializeDelegate <15>__DeserializeChangeMasteringLevelPacket; //Field offset: 0x78
		public static SerializeDelegate <16>__SerializePacket; //Field offset: 0x80
		public static DeserializeDelegate <17>__DeserializeTradersInfoPacket; //Field offset: 0x88
		public static DeserializeDelegate <18>__DeserializeStringNotificationPacket; //Field offset: 0x90

	}

	internal sealed class DeserializeDelegate`1 : MulticastDelegate
	{

		public DeserializeDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IBitReaderStream reader, AsyncCallback callback, object object) { }

		public override Nullable EndInvoke(IAsyncResult result) { }

		public override Nullable Invoke(IBitReaderStream reader) { }

	}

	internal sealed class SerializeDelegate`1 : MulticastDelegate
	{

		public SerializeDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IBitWriterStream writer, ref Nullable t, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Nullable t, IAsyncResult result) { }

		public override void Invoke(IBitWriterStream writer, ref Nullable t) { }

	}


	[Extension]
	public static INestable Deserialize(IBitReaderStream reader, DeserializeDelegate deserializeDelegate) { }

	[Extension]
	public static Nullable DeserializeAcceptHitDebugDataPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeChangeMasteringLevelPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeChangeSkillExperiencePacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeClientConfirmCallbackPacket(IBitReaderStream reader) { }

	[Extension]
	public static CommonPacket DeserializeCommonPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeConditionValueChangedPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeDeathInventorySyncPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeighthouseTraderZoneDebugToolPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeInteractWithBtrPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeInteractWithTripwirePacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeInventoryHashPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeKeyUsagePacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeLighthouseTraderZonePacket(IBitReaderStream reader) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static void DeserializePacket(IBitReaderStream reader, ref Nullable packet) { }

	[Extension]
	public static Nullable DeserializePlayerDiedPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeRadioTransmitterPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeShowStatNotificationPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeStringNotificationPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeSwitchRenderersPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeSyncPositionPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeSyncSessionExperiencePacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeTradersInfoPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeTriggeredPerkPacket(IBitReaderStream reader) { }

	[Extension]
	public static Nullable DeserializeWeaponOverheatPacket(IBitReaderStream reader) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref QuestCondition condition) { }

	[Extension]
	public static void Serialize(IBitWriterStream writer, INestable nestable, SerializeDelegate serializeDelegate) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

}

