namespace EFT.HealthSystem;

public struct StimulatorStore
{
	public string BuffsName; //Field offset: 0x0
	public string ItemTemplateId; //Field offset: 0x8
	[CompilerGenerated]
	private EBodyPart <LastAppliedTo>k__BackingField; //Field offset: 0x10

	public EBodyPart LastAppliedTo
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[CompilerGenerated]
	[IsReadOnly]
	public EBodyPart get_LastAppliedTo() { }

	[CompilerGenerated]
	public void set_LastAppliedTo(EBodyPart value) { }

}

