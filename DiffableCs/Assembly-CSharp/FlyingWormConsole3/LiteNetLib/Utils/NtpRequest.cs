namespace FlyingWormConsole3.LiteNetLib.Utils;

internal sealed class NtpRequest
{
	private const int ResendTimer = 1000; //Field offset: 0x0
	private const int KillTimer = 10000; //Field offset: 0x0
	public const int DefaultPort = 123; //Field offset: 0x0
	private readonly IPEndPoint _ntpEndPoint; //Field offset: 0x10
	private int _resendTime; //Field offset: 0x18
	private int _killTime; //Field offset: 0x1C

	public bool NeedToKill
	{
		 get { } //Length: 11
	}

	public NtpRequest(IPEndPoint endPoint) { }

	public bool get_NeedToKill() { }

	public bool Send(NetSocket socket, int time) { }

}

