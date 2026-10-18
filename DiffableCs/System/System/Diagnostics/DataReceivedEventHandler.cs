namespace System.Diagnostics;

public sealed class DataReceivedEventHandler : MulticastDelegate
{

	public DataReceivedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, DataReceivedEventArgs e) { }

}

