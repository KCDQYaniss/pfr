namespace JsonType;

public interface ISpecification
{

	public float Value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float get_Value() { }

	public string GetFullStringValue(string displayName) { }

	public string GetStringValue(string postfix = "") { }

	public void set_Value(float value) { }

}

