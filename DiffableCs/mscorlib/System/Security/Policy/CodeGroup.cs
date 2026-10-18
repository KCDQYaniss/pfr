namespace System.Security.Policy;

[ComVisible(True)]
public abstract class CodeGroup
{

	public abstract PolicyStatement Resolve(Evidence evidence) { }

}

