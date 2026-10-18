namespace Cinemachine.Utility;

public class CinemachineDebug
{
	internal sealed class OnGUIDelegate : MulticastDelegate
	{

		public OnGUIDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private static HashSet mClients; //Field offset: 0x0
	public static OnGUIDelegate OnGUIHandlers; //Field offset: 0x8
	private static List mAvailableStringBuilders; //Field offset: 0x10

	public CinemachineDebug() { }

	public static Rect GetScreenPos(Object client, string text, GUIStyle style) { }

	public static void ReleaseScreenPos(Object client) { }

	public static void ReturnToPool(StringBuilder sb) { }

	public static StringBuilder SBFromPool() { }

}

