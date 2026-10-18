namespace RootMotion;

public static class Warning
{
	internal sealed class Logger : MulticastDelegate
	{

		public Logger(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	public static bool logged; //Field offset: 0x0

	public static void Log(string message, Logger logger, bool logInEditMode = false) { }

	public static void Log(string message, Transform context, bool logInEditMode = false) { }

}

