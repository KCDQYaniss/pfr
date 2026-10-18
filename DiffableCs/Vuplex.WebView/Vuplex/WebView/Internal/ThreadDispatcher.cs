namespace Vuplex.WebView.Internal;

public class ThreadDispatcher : MonoBehaviour
{
	private static List _actions; //Field offset: 0x0
	private static List _backlog; //Field offset: 0x8
	private static ThreadDispatcher _instance; //Field offset: 0x10
	private static int _mainThreadId; //Field offset: 0x18
	private static bool _queued; //Field offset: 0x1C

	public static bool CurrentlyOnMainThread
	{
		 get { } //Length: 233
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void _initialize() { }

	private static ThreadDispatcher() { }

	public ThreadDispatcher() { }

	public static bool get_CurrentlyOnMainThread() { }

	public static void RunOnMainThread(Action action) { }

	private void Update() { }

}

