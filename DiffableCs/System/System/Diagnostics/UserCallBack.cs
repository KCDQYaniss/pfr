namespace System.Diagnostics;

internal sealed class UserCallBack : MulticastDelegate
{

	public UserCallBack(object object, IntPtr method) { }

	public override void Invoke(string data) { }

}

