namespace EFT.UI;

public abstract class StatVariable
{
	public readonly MongoID Id; //Field offset: 0x10
	public readonly string NameKey; //Field offset: 0x28
	public readonly bool ShowIfZeroValue; //Field offset: 0x30

	public abstract ETextGameVariableType Type
	{
		 get { } //Length: 0
	}

	protected StatVariable(MongoID id, string nameKey, bool showIfZeroValue = false) { }

	public abstract ETextGameVariableType get_Type() { }

	protected string GetDisplayName() { }

	public abstract string GetDisplayText(int currentValue) { }

}

