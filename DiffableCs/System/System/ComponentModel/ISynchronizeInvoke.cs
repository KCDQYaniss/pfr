namespace System.ComponentModel;

public interface ISynchronizeInvoke
{

	public bool InvokeRequired
	{
		 get { } //Length: 0
	}

	public IAsyncResult BeginInvoke(Delegate method, object[] args) { }

	public bool get_InvokeRequired() { }

	public object Invoke(Delegate method, object[] args) { }

}

