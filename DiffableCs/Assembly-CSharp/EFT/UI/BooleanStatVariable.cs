namespace EFT.UI;

public class BooleanStatVariable : StatVariable
{

	public virtual ETextGameVariableType Type
	{
		 get { } //Length: 6
	}

	public BooleanStatVariable(MongoID id, string nameKey, bool showIfZeroValue = false) { }

	public virtual ETextGameVariableType get_Type() { }

	public virtual string GetDisplayText(int currentValue) { }

}

