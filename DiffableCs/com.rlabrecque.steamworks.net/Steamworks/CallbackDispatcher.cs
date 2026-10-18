namespace Steamworks;

public static class CallbackDispatcher
{
	internal sealed class SteamworksExceptionHandler : MulticastDelegate
	{

		public SteamworksExceptionHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Exception e, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Exception e) { }

	}

	public static SteamworksExceptionHandler ExceptionHandler; //Field offset: 0x0
	private static Dictionary m_registeredCallbacks; //Field offset: 0x8
	private static Dictionary m_registeredGameServerCallbacks; //Field offset: 0x10
	private static Dictionary m_registeredCallResults; //Field offset: 0x18
	private static object m_sync; //Field offset: 0x20
	private static IntPtr m_pCallbackMsg; //Field offset: 0x28
	private static int m_initCount; //Field offset: 0x30

	public static bool IsInitialized
	{
		 get { } //Length: 87
	}

	private static CallbackDispatcher() { }

	private static void DefaultExceptionHandler(Exception e) { }

	public static bool get_IsInitialized() { }

	internal static void Initialize() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void InitOnPlayMode() { }

	internal static void Register(Callback cb) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public static void Register(SteamAPICall_t asyncCall, CallResult cr) { }

	internal static void RunFrame(bool isGameServer) { }

	internal static void Shutdown() { }

	internal static void Unregister(Callback cb) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public static void Unregister(SteamAPICall_t asyncCall, CallResult cr) { }

	private static void UnregisterAll() { }

}

