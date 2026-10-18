namespace System.ComponentModel;

[DefaultEvent("DoWork")]
public class BackgroundWorker : Component
{
	private bool _canCancelWorker; //Field offset: 0x28
	private bool _cancellationPending; //Field offset: 0x29

	public bool WorkerSupportsCancellation
	{
		 get { } //Length: 5
	}

	public void CancelAsync() { }

	public bool get_WorkerSupportsCancellation() { }

}

