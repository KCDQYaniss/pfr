namespace System.Security.Policy;

[ComVisible(True)]
public sealed class PolicyLevel
{
	private CodeGroup root_code_group; //Field offset: 0x10

	internal PolicyLevel() { }

	public PolicyStatement Resolve(Evidence evidence) { }

}

