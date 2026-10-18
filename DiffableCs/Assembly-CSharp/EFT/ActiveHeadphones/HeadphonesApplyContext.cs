namespace EFT.ActiveHeadphones;

[IsReadOnly]
public struct HeadphonesApplyContext
{
	[CompilerGenerated]
	private readonly EHeadphonesTemplateRole <Role>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly HeadphonesTemplate <Template>k__BackingField; //Field offset: 0x8

	public bool IsBaseline
	{
		 get { } //Length: 7
	}

	public EHeadphonesTemplateRole Role
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public HeadphonesTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HeadphonesApplyContext(EHeadphonesTemplateRole role, HeadphonesTemplate template) { }

	public bool get_IsBaseline() { }

	[CompilerGenerated]
	public EHeadphonesTemplateRole get_Role() { }

	[CompilerGenerated]
	public HeadphonesTemplate get_Template() { }

}

