namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop
{

	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	[NativeMethod(IsFreeFunction = True)]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	public static PlayerLoopSystem GetDefaultPlayerLoop() { }

	[NativeMethod(IsFreeFunction = True)]
	private static PlayerLoopSystemInternal[] GetDefaultPlayerLoopInternal() { }

	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List internalSys) { }

	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	[NativeMethod(IsFreeFunction = True)]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

