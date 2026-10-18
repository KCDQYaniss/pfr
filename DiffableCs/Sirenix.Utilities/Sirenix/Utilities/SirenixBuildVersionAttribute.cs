namespace Sirenix.Utilities;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
public class SirenixBuildVersionAttribute : Attribute
{
	[CompilerGenerated]
	private string <Version>k__BackingField; //Field offset: 0x10

	public private string Version
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SirenixBuildVersionAttribute(string version) { }

	[CompilerGenerated]
	public string get_Version() { }

	[CompilerGenerated]
	private void set_Version(string value) { }

}

