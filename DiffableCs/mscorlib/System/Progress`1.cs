namespace System;

public class Progress`1 : IProgress
{
	private readonly SynchronizationContext _synchronizationContext; //Field offset: 0x0
	private readonly Action _handler; //Field offset: 0x0
	private readonly SendOrPostCallback _invokeHandlers; //Field offset: 0x0
	[CompilerGenerated]
	private EventHandler ProgressChanged; //Field offset: 0x0

	public Progress`1() { }

	private void InvokeHandlers(object state) { }

	protected override void OnReport(T value) { }

	private override void System.IProgress<T>.Report(T value) { }

}

