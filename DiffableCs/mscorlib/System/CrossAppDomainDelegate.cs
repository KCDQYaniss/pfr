namespace System;

[ComVisible(True)]
public sealed class CrossAppDomainDelegate : MulticastDelegate
{

	public CrossAppDomainDelegate(object object, IntPtr method) { }

	public override void Invoke() { }

}

