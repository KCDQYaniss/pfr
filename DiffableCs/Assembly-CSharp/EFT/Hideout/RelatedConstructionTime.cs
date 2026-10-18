namespace EFT.Hideout;

public sealed class RelatedConstructionTime : RelatedData
{
	public float Data; //Field offset: 0x10

	public virtual bool IsActive
	{
		 get { } //Length: 3
	}

	public virtual EPanelType Type
	{
		 get { } //Length: 6
	}

	public virtual object Value
	{
		 get { } //Length: 76
	}

	public RelatedConstructionTime() { }

	public virtual bool get_IsActive() { }

	public virtual EPanelType get_Type() { }

	public virtual object get_Value() { }

}

