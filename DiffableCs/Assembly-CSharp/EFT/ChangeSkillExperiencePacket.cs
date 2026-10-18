namespace EFT;

public struct ChangeSkillExperiencePacket : IUpdatableNestable, INestable
{
	public byte SkillId; //Field offset: 0x0
	public float Value; //Field offset: 0x4
	public float Effectiveness; //Field offset: 0x8
	public float PointsEarned; //Field offset: 0xC
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x10

	public override INestable Nested
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private override bool EFT.IUpdatableNestable<EFT.ChangeSkillExperiencePacket>.TryUpdate(ChangeSkillExperiencePacket source) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override INestable get_Nested() { }

	[CompilerGenerated]
	public override void set_Nested(INestable value) { }

}

