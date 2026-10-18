namespace EFT.Hideout;

public abstract class RelatedData
{

	[JsonIgnore]
	public abstract bool IsActive
	{
		 get { } //Length: 0
	}

	[JsonIgnore]
	public abstract EPanelType Type
	{
		 get { } //Length: 0
	}

	[JsonIgnore]
	public abstract object Value
	{
		 get { } //Length: 0
	}

	protected RelatedData() { }

	public abstract bool get_IsActive() { }

	public abstract EPanelType get_Type() { }

	public abstract object get_Value() { }

}

