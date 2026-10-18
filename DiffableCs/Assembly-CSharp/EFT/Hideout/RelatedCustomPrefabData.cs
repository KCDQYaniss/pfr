namespace EFT.Hideout;

public sealed class RelatedCustomPrefabData : RelatedData
{
	public UIElement PanelPrefab; //Field offset: 0x10

	public virtual bool IsActive
	{
		 get { } //Length: 203
	}

	public virtual EPanelType Type
	{
		 get { } //Length: 6
	}

	public virtual object Value
	{
		 get { } //Length: 5
	}

	public RelatedCustomPrefabData() { }

	public virtual bool get_IsActive() { }

	public virtual EPanelType get_Type() { }

	public virtual object get_Value() { }

}

