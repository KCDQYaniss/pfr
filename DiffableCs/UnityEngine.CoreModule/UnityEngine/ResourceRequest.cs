namespace UnityEngine;

[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation
{
	internal string m_Path; //Field offset: 0x20
	internal Type m_Type; //Field offset: 0x28

	public Object asset
	{
		 get { } //Length: 20
	}

	public ResourceRequest() { }

	public Object get_asset() { }

	protected override Object GetResult() { }

}

