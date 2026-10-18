namespace Sirenix.Serialization.Utilities;

internal static class UnityVersion
{
	public static readonly int Major; //Field offset: 0x0
	public static readonly int Minor; //Field offset: 0x4

	private static UnityVersion() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void EnsureLoaded() { }

	public static bool IsVersionOrGreater(int major, int minor) { }

}

