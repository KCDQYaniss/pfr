namespace Comfort.Communication;

public interface ICommunicator
{

	public event Action OnError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IConnection Connection
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public long Add(T obj) { }

	[CompilerGenerated]
	public void add_OnError(Action value) { }

	public long AddUnreliable(T obj) { }

	public T Get() { }

	public T Get(long index) { }

	public IConnection get_Connection() { }

	public bool Remove() { }

	public bool Remove(T obj) { }

	public bool Remove(long index) { }

	[CompilerGenerated]
	public void remove_OnError(Action value) { }

	public void set_Connection(IConnection value) { }

	public T TryGet() { }

	public T TryGet(long index) { }

	public bool TryRemove() { }

	public bool TryRemove(T obj) { }

	public bool TryRemove(long index) { }

}

