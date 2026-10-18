namespace Steamworks;

[AttributeUsage(AttributeTargets::Struct (8), AllowMultiple = False)]
internal class CallbackIdentityAttribute : Attribute
{
	[CompilerGenerated]
	private int <Identity>k__BackingField; //Field offset: 0x10

	public int Identity
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CallbackIdentityAttribute(int callbackNum) { }

	[CompilerGenerated]
	public int get_Identity() { }

	[CompilerGenerated]
	public void set_Identity(int value) { }

}

