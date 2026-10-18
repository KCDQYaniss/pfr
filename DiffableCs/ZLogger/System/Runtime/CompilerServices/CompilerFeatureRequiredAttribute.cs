namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class CompilerFeatureRequiredAttribute : Attribute
{
	public const string RefStructs = "RefStructs"; //Field offset: 0x0
	public const string RequiredMembers = "RequiredMembers"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <FeatureName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsOptional>k__BackingField; //Field offset: 0x18

	public string FeatureName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsOptional
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CompilerFeatureRequiredAttribute(string featureName) { }

	[CompilerGenerated]
	public string get_FeatureName() { }

	[CompilerGenerated]
	public bool get_IsOptional() { }

	[CompilerGenerated]
	public void set_IsOptional(bool value) { }

}

