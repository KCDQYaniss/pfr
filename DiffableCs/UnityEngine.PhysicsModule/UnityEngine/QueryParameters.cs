namespace UnityEngine;

public struct QueryParameters
{
	public int layerMask; //Field offset: 0x0
	public bool hitMultipleFaces; //Field offset: 0x4
	public QueryTriggerInteraction hitTriggers; //Field offset: 0x8
	public bool hitBackfaces; //Field offset: 0xC

	public static QueryParameters Default
	{
		 get { } //Length: 16
	}

	public QueryParameters(int layerMask = -5, bool hitMultipleFaces = false, QueryTriggerInteraction hitTriggers = 0, bool hitBackfaces = false) { }

	public static QueryParameters get_Default() { }

}

