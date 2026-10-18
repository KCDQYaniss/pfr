namespace UnityEngine;

public sealed class ShaderVariantCollection : Object
{

	public bool isWarmedUp
	{
		[NativeName("IsWarmedUp")]
		 get { } //Length: 78
	}

	public int variantCount
	{
		 get { } //Length: 78
	}

	[NativeName("IsWarmedUp")]
	public bool get_isWarmedUp() { }

	public int get_variantCount() { }

	[NativeName("WarmupShaders")]
	public void WarmUp() { }

}

