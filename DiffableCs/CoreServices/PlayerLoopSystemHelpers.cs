//Type is in global namespace

public static class PlayerLoopSystemHelpers
{
	internal enum EOrderType
	{
		First = 0,
		Last = 1,
	}

	private static readonly PlayerLoopSystem _currentLoop; //Field offset: 0x0

	private static PlayerLoopSystemHelpers() { }

	private static bool ApplyPlayerLoopSystemChanges(PlayerLoopSystem searchRoot, PlayerLoopSystem playerLoopSystem) { }

	private static void CollectAllPlayerLoopSystemsTypes(PlayerLoopSystem playerLoopSystem, StringBuilder output, string indent = "") { }

	private static bool EditSystem(PlayerLoopSystem playerLoopSystem, PlayerLoopSystem[] subSystemList) { }

	public static bool FindParentPlayerLoopSystem(PlayerLoopSystem root, Type type, out PlayerLoopSystem playerLoopSystem, out int index) { }

	private static bool FindPlayerLoopSystem(PlayerLoopSystem root, Type type, out PlayerLoopSystem playerLoopSystem) { }

	public static bool FindPlayerLoopSystem(Type type, out PlayerLoopSystem playerLoopSystem) { }

	public static void InsertAsSiblingSystem(Type siblingType, PlayerLoopSystem newSystem, EOrderType orderType) { }

	public static void InsertAsSubSystem(Type rootType, PlayerLoopSystem newSystem, EOrderType orderType) { }

	public static void PrintAllPlayerLoopSystems() { }

	private static bool RemoveLoopSystem(PlayerLoopSystem searchRoot, Type removeSystemType) { }

	public static void RemoveLoopSystem(Type removeSystemType) { }

	public static void ResetGameLoop() { }

}

