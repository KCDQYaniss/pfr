namespace System.IO;

public sealed class RenamedEventHandler : MulticastDelegate
{

	public RenamedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, RenamedEventArgs e) { }

}

