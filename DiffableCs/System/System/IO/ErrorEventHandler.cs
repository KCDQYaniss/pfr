namespace System.IO;

public sealed class ErrorEventHandler : MulticastDelegate
{

	public ErrorEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, ErrorEventArgs e) { }

}

