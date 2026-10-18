namespace BattlEye;

public sealed class BEClient : IDisposable
{
	[CompilerGenerated]
	private static class <>O
	{
		public static PrintMessageFn <0>__PfnPrintMessageStatic; //Field offset: 0x0
		public static SendPacketFn <1>__PfnSendPacketStatic; //Field offset: 0x8
		public static RequestRestartFn <2>__PfnRequestRestartStatic; //Field offset: 0x10

	}

	private sealed class BEClientWrapper
	{
		internal class BECL_BE_DATA
		{
			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class AddPeerFn : MulticastDelegate
			{

				public AddPeerFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPeerGUID, int nGUIDLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvPeerGUID, int nGUIDLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class CommandFn : MulticastDelegate
			{

				public CommandFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(string pstrCommand, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(string pstrCommand) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class DecryptServerPacketFn : MulticastDelegate
			{

				public DecryptServerPacketFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPacket, int nLength, IntPtr pvDecryptedPacket, ref int pnDecryptedLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(ref int pnDecryptedLength, IAsyncResult result) { }

				public override void Invoke(IntPtr pvPacket, int nLength, IntPtr pvDecryptedPacket, ref int pnDecryptedLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class EncryptClientPacketFn : MulticastDelegate
			{

				public EncryptClientPacketFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPacket, int nLength, IntPtr pvEncryptedPacket, ref int pnEncryptedLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(ref int pnEncryptedLength, IAsyncResult result) { }

				public override void Invoke(IntPtr pvPacket, int nLength, IntPtr pvEncryptedPacket, ref int pnEncryptedLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class ExitFn : MulticastDelegate
			{

				public ExitFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

				public override bool EndInvoke(IAsyncResult result) { }

				public override bool Invoke() { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class OnReceiveAuthTicketFn : MulticastDelegate
			{

				public OnReceiveAuthTicketFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvTicket, int nTicketLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvTicket, int nTicketLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class ReceivedPacketFn : MulticastDelegate
			{

				public ReceivedPacketFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPacket, int nLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvPacket, int nLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class RemovePeerFn : MulticastDelegate
			{

				public RemovePeerFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPeerGUID, int nGUIDLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvPeerGUID, int nGUIDLength) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class RunFn : MulticastDelegate
			{

				public RunFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke() { }

			}

			public ExitFn pfnExit; //Field offset: 0x10
			public RunFn pfnRun; //Field offset: 0x18
			public CommandFn pfnCommand; //Field offset: 0x20
			public ReceivedPacketFn pfnReceivedPacket; //Field offset: 0x28
			public OnReceiveAuthTicketFn pfnOnReceiveAuthTicket; //Field offset: 0x30
			public AddPeerFn pfnAddPeer; //Field offset: 0x38
			public RemovePeerFn pfnRemovePeer; //Field offset: 0x40
			public IntPtr pvEncryptionKey; //Field offset: 0x48
			public int nEncryptionKeyLength; //Field offset: 0x50
			public EncryptClientPacketFn pfnEncryptClientPacket; //Field offset: 0x58
			public DecryptServerPacketFn pfnDecryptServerPacket; //Field offset: 0x60

			public BECL_BE_DATA() { }

		}

		internal class BECL_GAME_DATA
		{
			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class DisconnectPeerFn : MulticastDelegate
			{

				public DisconnectPeerFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPeerGUID, int nGUIDLength, string pstrReason, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvPeerGUID, int nGUIDLength, string pstrReason) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class PrintMessageFn : MulticastDelegate
			{

				public PrintMessageFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(string pstrMessage, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(string pstrMessage) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class RequestRestartFn : MulticastDelegate
			{

				public RequestRestartFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(int iReason, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(int iReason) { }

			}

			[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
			internal sealed class SendPacketFn : MulticastDelegate
			{

				public SendPacketFn(object object, IntPtr method) { }

				public override IAsyncResult BeginInvoke(IntPtr pvPacket, int nLength, AsyncCallback callback, object object) { }

				public override void EndInvoke(IAsyncResult result) { }

				public override void Invoke(IntPtr pvPacket, int nLength) { }

			}

			public IntPtr pstrGameVersion; //Field offset: 0x10
			public uint uiAddress; //Field offset: 0x18
			public ushort usPort; //Field offset: 0x1C
			public PrintMessageFn pfnPrintMessage; //Field offset: 0x20
			public RequestRestartFn pfnRequestRestart; //Field offset: 0x28
			public SendPacketFn pfnSendPacket; //Field offset: 0x30
			public DisconnectPeerFn pfnDisconnectPeer; //Field offset: 0x38

			public BECL_GAME_DATA() { }

			public virtual string ToString() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class BEClientGetVerFn : MulticastDelegate
		{

			public BEClientGetVerFn(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			public override int EndInvoke(IAsyncResult result) { }

			public override int Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class BEClientInitFn : MulticastDelegate
		{

			public BEClientInitFn(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(int iIntegrationVersion, in BECL_GAME_DATA pGameData, out BECL_BE_DATA pBEData, AsyncCallback callback, object object) { }

			public override bool EndInvoke(IAsyncResult result) { }

			public override bool Invoke(int iIntegrationVersion, in BECL_GAME_DATA pGameData, out BECL_BE_DATA pBEData) { }

		}

		public const int BECLIENT_INTEGRATION_VERSION = 4; //Field offset: 0x0

		public BEClientWrapper() { }

		public static GetFuncResult GetInitFunction(IntPtr loadDll) { }

		public static GetFuncResult GetVerFunction(IntPtr dllPtr) { }

	}

	private enum EInstanceStatus
	{
		None = 0,
		NotInitialized = 1,
		SuccessfullyInitialized = 2,
		Destroying = 3,
		Destroyed = 4,
	}

	internal enum ERestartReason
	{
		BATTLEYE_UnknownRestartReason = -1,
		BATTLEYE_ServiceNotRunningProperly = 0,
		BATTLEYE_ServiceNeedsToBeUpdated = 1,
	}

	internal sealed class IsLogLevelEnabledDelegate : MulticastDelegate
	{

		public IsLogLevelEnabledDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LogLevel logLevel, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(LogLevel logLevel) { }

	}

	internal sealed class LogDelegate : MulticastDelegate
	{

		public LogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LogLevel logLevel, string format, object[] args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LogLevel logLevel, string format, object[] args) { }

	}

	private class Logger : ILogHandler
	{
		private static MD5 md5; //Field offset: 0x0
		private static StringBuilder sBuilder; //Field offset: 0x8
		private readonly LogDelegate _logDelegate; //Field offset: 0x10
		private readonly IsLogLevelEnabledDelegate _isLogLevelEnabledDelegate; //Field offset: 0x18

		private static Logger() { }

		public Logger(LogDelegate logDelegate, IsLogLevelEnabledDelegate isLogLevelEnabledDelegate) { }

		private static string hashToString(byte[] data) { }

		public bool IsEnabled(LogLevel logLevel) { }

		public void Log(LogLevel logLevel, string format, object[] args) { }

		public override void LogException(Exception exception, Object context) { }

		public override void LogFormat(LogType logType, Object context, string format, object[] args) { }

	}

	private static BEClient Instance; //Field offset: 0x0
	public const string BELIENT_DLL_FOLDER = "/../BattlEye/"; //Field offset: 0x0
	public const string BECLIENT_DLL_FOLDER_EDITOR = "/../../tools/windows/Battleye/Windows/BattlEye/"; //Field offset: 0x0
	public const string BECLIENT_BATTLEYE_FOLDER_NAME = "BattlEye/"; //Field offset: 0x0
	public const string BECLIENT_WINDOWS_FOLDER_EDITOR = "/../../tools/windows/Battleye/Windows/"; //Field offset: 0x0
	public const string BECLIENT_DLL_NAME = "BEClient_x64.dll"; //Field offset: 0x0
	private static GCHandle _instanceGcHandle; //Field offset: 0x8
	private static string _applicationDataPath; //Field offset: 0x10
	private static Logger _logger; //Field offset: 0x18
	private static LibraryLoaderUtility _loaderUtility; //Field offset: 0x20
	private static readonly ReaderWriterLockSlim LifecycleLock; //Field offset: 0x28
	private IntPtr _beDllPtr; //Field offset: 0x10
	private IBattlEyeClientRequestHandler _requestHandler; //Field offset: 0x18
	private readonly List _pinnedObjects; //Field offset: 0x20
	private BEClientInitFn _initFunction; //Field offset: 0x28
	private BEClientGetVerFn _getVersionFunction; //Field offset: 0x30
	private BECL_BE_DATA _beClientData; //Field offset: 0x38
	private BECL_GAME_DATA _beClientGameData; //Field offset: 0x40
	private byte[] _openEncryptionKey; //Field offset: 0x48
	private int _openEncryptionKeyLength; //Field offset: 0x50
	private EInstanceStatus _initializationStatus; //Field offset: 0x54
	private bool _beClientDataExists; //Field offset: 0x58
	private bool _requestHandlerExists; //Field offset: 0x59
	private IntPtr _gameVersionAnsiPtr; //Field offset: 0x60

	private static string ApplicationDataPath
	{
		private get { } //Length: 371
	}

	public static byte[] OpenEncryptionKey
	{
		 get { } //Length: 369
	}

	public static int OpenEncryptionKeyLength
	{
		 get { } //Length: 364
	}

	private static BEClient() { }

	private BEClient(IntPtr beDllPtr, BEClientInitFn initFn, BEClientGetVerFn getVerFn) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void AcceptServerPacket(byte[] packet, int packetOffset, int packetLength) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void AcceptServerPacket(byte[] packet) { }

	public static void CacheStaticData() { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void Command(string pstrCommand) { }

	private static CreateInstanceResult CreateInstance(string path, LogDelegate logDelegate, IsLogLevelEnabledDelegate isLogLevelEnabledDelegate) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void DecryptPacket(byte[] encryptedPacket, int encryptedPacketOffset, int encryptedPacketLength, byte[] decryptedPacket, int decryptedPacketOffset, ref int decryptedPacketLength) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void DecryptServerPacket(byte[] encryptedPacket, int encryptedPacketOffset, int encryptedPacketLength, byte[] decryptedPacket, int decryptedPacketOffset, ref int decryptedPacketLength) { }

	private void DecryptServerPacketHotPath(byte[] encryptedPacket, int encryptedPacketOffset, int encryptedPacketLength, byte[] decryptedPacket, int decryptedPacketOffset, ref int decryptedPacketLength) { }

	private static void DestroyInstance() { }

	public override void Dispose() { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void EncryptClientPacket(byte[] sourcePacket, int sourcePacketOffset, int sourcePacketLength, byte[] encryptedPacket, int encryptedPacketOffset, ref int encryptedPacketLength) { }

	private void EncryptClientPacketHotPath(byte[] sourcePacket, int sourcePacketOffset, int sourcePacketLength, byte[] encryptedPacket, int encryptedPacketOffset, ref int encryptedPacketLength) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void EncryptPacket(byte[] sourcePacket, int sourcePacketOffset, int sourcePacketLength, byte[] encryptedPacket, int encryptedPacketOffset, ref int encryptedPacketLength) { }

	private bool Exit() { }

	protected virtual void Finalize() { }

	private static string get_ApplicationDataPath() { }

	public static byte[] get_OpenEncryptionKey() { }

	public static int get_OpenEncryptionKeyLength() { }

	public static string GetBEClientDllPath() { }

	public static string GetBuildDLLFolderPath() { }

	public static string GetEditorBEWindowsPath() { }

	public static string GetEditorDLLFolderPath() { }

	public static string GetEditorDllPath() { }

	public static string GetReleaseDllPath() { }

	private int GetVersion() { }

	private EInstanceStatus Init(string gameNameWithVersion, uint serverAddress, ushort serverPort, IBattlEyeClientRequestHandler requestHandler) { }

	private static bool IsInstanceSuccessfully() { }

	private void OnRequestRestart(ERestartReason reason) { }

	private void OnSendPacket(byte[] bePacket, int packetOffset, int packetLength) { }

	private void PfnPrintMessage(string message) { }

	[MonoPInvokeCallback(typeof(PrintMessageFn))]
	private static void PfnPrintMessageStatic(string message) { }

	private void PfnRequestRestart(int reasonCode) { }

	[MonoPInvokeCallback(typeof(RequestRestartFn))]
	private static void PfnRequestRestartStatic(int reasonCode) { }

	private void PfnSendPacket(IntPtr packetPointer, int packetByteLength) { }

	[MonoPInvokeCallback(typeof(SendPacketFn))]
	private static void PfnSendPacketStatic(IntPtr packetPointer, int packetByteLength) { }

	private void PinObject(object o) { }

	private void PinObjectIfNotNull(object o) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void ReceivedPacket(byte[] packet) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void ReceivedPacket(byte[] packet, int packetOffset, int packetLength) { }

	private void ReceivedPacketHotPath(byte[] packet, int packetOffset, int packetLength) { }

	private void ReleaseUnmanagedResources() { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	private void Run() { }

	private void RunHotPath() { }

	public static CreateInstanceResult Start(string gameNameWithVersion, uint serverAddress, ushort serverPort, IBattlEyeClientRequestHandler requestHandler, LogDelegate logDelegate, IsLogLevelEnabledDelegate isLogLevelEnabledDelegate) { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void Stop() { }

	[Conditional("BATTLEYE_ANTICHEAT")]
	public static void Update() { }

}

