namespace Steamworks;

public static class SteamRemotePlay
{

	public static bool BEnableRemotePlayTogetherDirectInput() { }

	public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) { }

	public static RemotePlayCursorID_t CreateMouseCursor(int nWidth, int nHeight, int nHotX, int nHotY, IntPtr pBGRA, int nPitch = 0) { }

	public static void DisableRemotePlayTogetherDirectInput() { }

	public static uint GetInput(RemotePlayInput_t[] pInput, uint unMaxEvents) { }

	public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) { }

	public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) { }

	public static uint GetSessionCount() { }

	public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) { }

	public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) { }

	public static void SetMouseCursor(RemotePlaySessionID_t unSessionID, RemotePlayCursorID_t unCursorID) { }

	public static void SetMousePosition(RemotePlaySessionID_t unSessionID, float flNormalizedX, float flNormalizedY) { }

	public static void SetMouseVisibility(RemotePlaySessionID_t unSessionID, bool bVisible) { }

	public static bool ShowRemotePlayTogetherUI() { }

}

