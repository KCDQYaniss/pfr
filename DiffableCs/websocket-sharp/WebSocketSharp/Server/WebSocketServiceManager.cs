namespace WebSocketSharp.Server;

[DefaultMember("Item")]
public class WebSocketServiceManager
{
	private Dictionary _hosts; //Field offset: 0x10
	private bool _keepClean; //Field offset: 0x18
	private Logger _log; //Field offset: 0x20
	private ServerState _state; //Field offset: 0x28
	private object _sync; //Field offset: 0x30
	private TimeSpan _waitTime; //Field offset: 0x38

	public int Count
	{
		 get { } //Length: 246
	}

	public IEnumerable Hosts
	{
		 get { } //Length: 340
	}

	public WebSocketServiceHost Item
	{
		 get { } //Length: 584
	}

	public bool KeepClean
	{
		 get { } //Length: 10
		 set { } //Length: 901
	}

	public IEnumerable Paths
	{
		 get { } //Length: 340
	}

	public TimeSpan WaitTime
	{
		 get { } //Length: 7
		 set { } //Length: 1050
	}

	internal WebSocketServiceManager(Logger log) { }

	public void AddService(string path, Action initializer) { }

	private bool canSet() { }

	public void Clear() { }

	public int get_Count() { }

	public IEnumerable get_Hosts() { }

	public WebSocketServiceHost get_Item(string path) { }

	public bool get_KeepClean() { }

	public IEnumerable get_Paths() { }

	public TimeSpan get_WaitTime() { }

	internal bool InternalTryGetServiceHost(string path, out WebSocketServiceHost host) { }

	public bool RemoveService(string path) { }

	public void set_KeepClean(bool value) { }

	public void set_WaitTime(TimeSpan value) { }

	internal void Start() { }

	internal void Stop(ushort code, string reason) { }

	public bool TryGetServiceHost(string path, out WebSocketServiceHost host) { }

}

