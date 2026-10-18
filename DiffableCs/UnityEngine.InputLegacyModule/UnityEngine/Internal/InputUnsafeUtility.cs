namespace UnityEngine.Internal;

[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility
{

	[NativeThrows]
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	internal static bool GetButton(string buttonName) { }

	[NativeThrows]
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	internal static bool GetKeyDownString(string name) { }

	[NativeThrows]
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	internal static bool GetKeyString(string name) { }

	[NativeThrows]
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	internal static bool GetKeyUpString(string name) { }

	[NativeThrows]
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

}

