namespace EFT.NetworkPackets;

[Extension]
public static class OneAndListExtensions
{

	[Extension]
	public static OneAndList ToOneAndList(List list) { }

	[Extension]
	public static OneAndList ToOneAndList(T[] list) { }

}

