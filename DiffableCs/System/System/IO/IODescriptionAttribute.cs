namespace System.IO;

[AttributeUsage(AttributeTargets::All (32767))]
public class IODescriptionAttribute : DescriptionAttribute
{

	public virtual string Description
	{
		 get { } //Length: 5
	}

	public IODescriptionAttribute(string description) { }

	public virtual string get_Description() { }

}

