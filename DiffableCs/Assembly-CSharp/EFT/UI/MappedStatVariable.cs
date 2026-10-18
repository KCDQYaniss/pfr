namespace EFT.UI;

public class MappedStatVariable : StatVariable
{
	public ValueMapping[] mappings; //Field offset: 0x38

	public virtual ETextGameVariableType Type
	{
		 get { } //Length: 3
	}

	public MappedStatVariable(MongoID id, string nameKey, ValueMapping[] mappings, bool showIfZeroValue = false) { }

	private static ValueMapping FindMappingForValue(ValueMapping[] mappings, int value) { }

	public virtual ETextGameVariableType get_Type() { }

	public virtual string GetDisplayText(int currentValue) { }

	public string GetLocalizedVariableValue(int currentValue) { }

}

