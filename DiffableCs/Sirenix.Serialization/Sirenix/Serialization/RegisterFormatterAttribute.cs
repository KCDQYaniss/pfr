namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public class RegisterFormatterAttribute : Attribute
{
	[CompilerGenerated]
	private Type <FormatterType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Type <WeakFallback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x20

	public private Type FormatterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Type WeakFallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RegisterFormatterAttribute(Type formatterType, int priority = 0) { }

	public RegisterFormatterAttribute(Type formatterType, Type weakFallback, int priority = 0) { }

	[CompilerGenerated]
	public Type get_FormatterType() { }

	[CompilerGenerated]
	public int get_Priority() { }

	[CompilerGenerated]
	public Type get_WeakFallback() { }

	[CompilerGenerated]
	private void set_FormatterType(Type value) { }

	[CompilerGenerated]
	private void set_Priority(int value) { }

	[CompilerGenerated]
	private void set_WeakFallback(Type value) { }

}

