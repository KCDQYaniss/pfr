namespace EFT.Console.Core;

[AttributeUsage(AttributeTargets::Parameter (2048))]
public sealed class ConsoleArgumentAttribute : Attribute
{
	[CompilerGenerated]
	private readonly object <DefaultValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x18

	public object DefaultValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ConsoleArgumentAttribute(object defaultValue, string description = "") { }

	[CompilerGenerated]
	public object get_DefaultValue() { }

	[CompilerGenerated]
	public string get_Description() { }

}

