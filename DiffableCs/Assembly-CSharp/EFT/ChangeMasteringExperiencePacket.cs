namespace EFT;

public struct ChangeMasteringExperiencePacket : IUpdatableNestable, INestable
{
	public string GroupName; //Field offset: 0x0
	public float Value; //Field offset: 0x8
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

	private override bool EFT.IUpdatableNestable<EFT.ChangeMasteringExperiencePacket>.TryUpdate(ChangeMasteringExperiencePacket source) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override INestable get_Nested() { }

	[CompilerGenerated]
	public override void set_Nested(INestable value) { }

}

