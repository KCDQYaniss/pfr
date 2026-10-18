namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class UnityExtensions
{
	private static readonly ValueGetter UnityObjectCachedPtrFieldGetter; //Field offset: 0x0

	private static UnityExtensions() { }

	[Extension]
	public static bool SafeIsUnityNull(Object obj) { }

}

