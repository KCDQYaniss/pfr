namespace Dissonance.Threading;

internal interface IThread
{

	public bool IsStarted
	{
		 get { } //Length: 0
	}

	public bool get_IsStarted() { }

	public void Join() { }

	public void Start() { }

}

