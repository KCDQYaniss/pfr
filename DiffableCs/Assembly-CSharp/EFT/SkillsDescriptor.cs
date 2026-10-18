namespace EFT;

[GenerateBinarySerialization]
public sealed class SkillsDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal SkillInfoDescriptor <.ctor>b__5_0(Skill skill) { }

		internal MasteringInfoDescriptor <.ctor>b__5_1(KeyValuePair m) { }

	}

	[GenerateBinarySerialization]
	internal sealed class MasteringInfoDescriptor
	{
		[JsonProperty("Id")]
		public string Id; //Field offset: 0x10
		[JsonProperty("Progress")]
		public float Progress; //Field offset: 0x18
		[JsonProperty("KillCount")]
		public int KillCount; //Field offset: 0x1C

		public MasteringInfoDescriptor() { }

	}

	[GenerateBinarySerialization]
	internal sealed class SkillInfoDescriptor
	{
		[JsonProperty("Id")]
		public ESkillId Id; //Field offset: 0x10
		[JsonProperty("Progress")]
		public float Progress; //Field offset: 0x14
		[JsonProperty("PointsEarnedDuringSession")]
		public float PointsEarnedDuringSession; //Field offset: 0x18
		[JsonProperty("LastAccess")]
		public int LastAccess; //Field offset: 0x1C

		public SkillInfoDescriptor() { }

	}

	[JsonProperty("Common")]
	public SkillInfoDescriptor[] Common; //Field offset: 0x10
	[JsonProperty("Mastering")]
	public MasteringInfoDescriptor[] Mastering; //Field offset: 0x18

	public SkillsDescriptor() { }

	public SkillsDescriptor(SkillManager skillManager) { }

}

