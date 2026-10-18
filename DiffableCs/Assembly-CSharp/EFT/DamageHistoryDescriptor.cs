namespace EFT;

[GenerateBinarySerialization]
public sealed class DamageHistoryDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10
		public static Func <>9__7_0; //Field offset: 0x18
		public static Func <>9__7_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal EBodyPart <OnJSONDeserialized>b__7_0(KeyValuePair pair) { }

		internal BodyPartDamageHistoryDescriptor <OnJSONDeserialized>b__7_1(KeyValuePair pair) { }

		internal EBodyPart <OnJSONSerializing>b__6_0(KeyValuePair pair) { }

		internal List <OnJSONSerializing>b__6_1(KeyValuePair pair) { }

	}

	[JsonProperty("LethalDamagePart")]
	public EBodyPart LethalDamagePart; //Field offset: 0x10
	[JsonProperty("LethalDamage")]
	[Nullable]
	public DamageStatsDescriptor LethalDamage; //Field offset: 0x18
	[JsonIgnore]
	public Dictionary BodyParts; //Field offset: 0x20
	[IgnoreBinarySerialization]
	[JsonProperty("BodyParts")]
	private Dictionary _jsonBodyParts; //Field offset: 0x28

	public DamageHistoryDescriptor() { }

	public DamageHistoryDescriptor(DamageHistory damageHistory) { }

	[OnDeserialized]
	private void OnJSONDeserialized(StreamingContext context) { }

	[OnSerializing]
	private void OnJSONSerializing(StreamingContext context) { }

}

