namespace EFT.Hideout;

public sealed class RelatedBoost : RelatedData
{
	public List Data; //Field offset: 0x10

	public virtual bool IsActive
	{
		 get { } //Length: 74
	}

	public virtual EPanelType Type
	{
		 get { } //Length: 6
	}

	public virtual object Value
	{
		 get { } //Length: 5
	}

	public RelatedBoost() { }

	public virtual bool get_IsActive() { }

	public virtual EPanelType get_Type() { }

	public virtual object get_Value() { }

}

