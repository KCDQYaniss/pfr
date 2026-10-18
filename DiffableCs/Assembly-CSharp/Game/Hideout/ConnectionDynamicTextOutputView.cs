namespace Game.Hideout;

public sealed class ConnectionDynamicTextOutputView : DynamicIterativeTextOutput
{
	private const string APPLY_DROP_RULES = "Apply drop rules to iptables on {ip}"; //Field offset: 0x0
	private const string STABLE_CHAIN = "A stable chain of servers is established"; //Field offset: 0x0
	private const string ATTEMPTING_TO_CONNECT = "Attempting to connect to 192.168.8.31..."; //Field offset: 0x0
	private const string CHECK_CONNECTION = "Check connection to 192.168.8.31 on {ip}"; //Field offset: 0x0
	private const string OK = "[OK][|time|][{0}]
"; //Field offset: 0x0
	private const string ERROR = "<color=red>[ERR][|time|][{0}]</color>
"; //Field offset: 0x0
	private const string COMPLETE = "<color=green>[ERR][|time|][{0}]</color>
"; //Field offset: 0x0
	private const string CONNECTING = "Connecting to server {ip}"; //Field offset: 0x0
	private const string CONNECTED = "Connected to server {ip}"; //Field offset: 0x0
	private const string CHECK_ANOTHER_CONNECTIONS = "Check another connections on {ip}"; //Field offset: 0x0
	private const string CHECK_ROOT_USER_ACTIVITY = "Check root user activity on {ip}"; //Field offset: 0x0
	private const string CHECK_SSL_LIB = "Check ssl-lib on {ip}"; //Field offset: 0x0
	private const string CHECK_SSL_PASS_LIB = "Check ssh-pass-lib on {ip}"; //Field offset: 0x0
	private const string CHECK_SSL_KEY = "Check ssh keys on {ip}"; //Field offset: 0x0
	[SerializeField]
	[Space]
	private bool _showEndStatus; //Field offset: 0x58
	[SerializeField]
	private Image _endStatusImage; //Field offset: 0x60
	[SerializeField]
	private Sprite _successStatusSprite; //Field offset: 0x68
	[SerializeField]
	private float _showEndStatusTime; //Field offset: 0x70
	private List _commonLines; //Field offset: 0x78
	private List _completeLines; //Field offset: 0x80
	private List _ips; //Field offset: 0x88
	private string _lastIp; //Field offset: 0x90

	public ConnectionDynamicTextOutputView() { }

	protected virtual void Clear() { }

	protected virtual string FormatTextLine(string text) { }

	protected virtual List GetNextLines() { }

	private string GetRandomIp() { }

	public virtual void Init() { }

	protected virtual void StartNextIteration() { }

	protected virtual void Stop() { }

	private void UpdateIps() { }

}

