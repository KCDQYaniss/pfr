namespace EFT.Hideout;

public sealed class RelatedProduction : RelatedData
{
	public BaseHideoutScheme[] Data; //Field offset: 0x10
	[CompilerGenerated]
	private readonly EPanelType <Type>k__BackingField; //Field offset: 0x18

	public virtual bool IsActive
	{
		 get { } //Length: 22
	}

	public virtual EPanelType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual object Value
	{
		 get { } //Length: 5
	}

	public RelatedProduction() { }

	public RelatedProduction(EPanelType panelType) { }

	public virtual bool get_IsActive() { }

	[CompilerGenerated]
	public virtual EPanelType get_Type() { }

	public virtual object get_Value() { }

}

