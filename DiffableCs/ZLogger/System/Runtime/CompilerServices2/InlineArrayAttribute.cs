namespace System.Runtime.CompilerServices2;

[AttributeUsage(AttributeTargets::Struct (8), AllowMultiple = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class InlineArrayAttribute : Attribute
{
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; //Field offset: 0x10

	public int Length
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public InlineArrayAttribute(int length) { }

	[CompilerGenerated]
	public int get_Length() { }

}

