namespace kcp2k;

public class Kcp
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__68_0; //Field offset: 0x8
		public static Action <>9__68_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Segment <.ctor>b__68_0() { }

		internal void <.ctor>b__68_1(Segment segment) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass85_0
	{
		public int offset; //Field offset: 0x0
		public Kcp <>4__this; //Field offset: 0x8

	}

	public struct AckItem
	{
		internal uint serialNumber; //Field offset: 0x0
		internal uint timestamp; //Field offset: 0x4

	}

	public const int RTO_NDL = 30; //Field offset: 0x0
	public const int FASTACK_LIMIT = 5; //Field offset: 0x0
	public const int PROBE_LIMIT = 120000; //Field offset: 0x0
	public const int PROBE_INIT = 7000; //Field offset: 0x0
	public const int THRESH_MIN = 2; //Field offset: 0x0
	public const int THRESH_INIT = 2; //Field offset: 0x0
	public const int DEADLINK = 20; //Field offset: 0x0
	public const int FRG_MAX = 255; //Field offset: 0x0
	public const int OVERHEAD = 24; //Field offset: 0x0
	public const int ACK_FAST = 3; //Field offset: 0x0
	public const int MTU_DEF = 1200; //Field offset: 0x0
	public const int INTERVAL = 100; //Field offset: 0x0
	public const int WND_SND = 32; //Field offset: 0x0
	public const int RTO_MIN = 100; //Field offset: 0x0
	public const int RTO_DEF = 200; //Field offset: 0x0
	public const int WND_RCV = 128; //Field offset: 0x0
	public const int CMD_PUSH = 81; //Field offset: 0x0
	public const int CMD_ACK = 82; //Field offset: 0x0
	public const int RTO_MAX = 60000; //Field offset: 0x0
	public const int CMD_WINS = 84; //Field offset: 0x0
	public const int ASK_SEND = 1; //Field offset: 0x0
	public const int ASK_TELL = 2; //Field offset: 0x0
	public const int CMD_WASK = 83; //Field offset: 0x0
	internal int state; //Field offset: 0x10
	private readonly uint conv; //Field offset: 0x14
	internal uint mtu; //Field offset: 0x18
	internal uint mss; //Field offset: 0x1C
	internal uint snd_una; //Field offset: 0x20
	internal uint snd_nxt; //Field offset: 0x24
	internal uint rcv_nxt; //Field offset: 0x28
	internal uint ssthresh; //Field offset: 0x2C
	internal int rx_rttval; //Field offset: 0x30
	internal int rx_srtt; //Field offset: 0x34
	internal int rx_rto; //Field offset: 0x38
	internal int rx_minrto; //Field offset: 0x3C
	internal uint snd_wnd; //Field offset: 0x40
	internal uint rcv_wnd; //Field offset: 0x44
	internal uint rmt_wnd; //Field offset: 0x48
	internal uint cwnd; //Field offset: 0x4C
	internal uint probe; //Field offset: 0x50
	internal uint interval; //Field offset: 0x54
	internal uint ts_flush; //Field offset: 0x58
	internal uint xmit; //Field offset: 0x5C
	internal uint nodelay; //Field offset: 0x60
	internal bool updated; //Field offset: 0x64
	internal uint ts_probe; //Field offset: 0x68
	internal uint probe_wait; //Field offset: 0x6C
	internal uint dead_link; //Field offset: 0x70
	internal uint incr; //Field offset: 0x74
	internal uint current; //Field offset: 0x78
	internal int fastresend; //Field offset: 0x7C
	internal int fastlimit; //Field offset: 0x80
	internal bool nocwnd; //Field offset: 0x84
	internal readonly Queue snd_queue; //Field offset: 0x88
	internal readonly Queue rcv_queue; //Field offset: 0x90
	internal readonly List snd_buf; //Field offset: 0x98
	internal readonly List rcv_buf; //Field offset: 0xA0
	internal readonly List acklist; //Field offset: 0xA8
	internal byte[] buffer; //Field offset: 0xB0
	private readonly Action output; //Field offset: 0xB8
	private readonly Pool SegmentPool; //Field offset: 0xC0

	public int State
	{
		 get { } //Length: 164
	}

	public int WaitRcv
	{
		 get { } //Length: 100
	}

	public int WaitSnd
	{
		 get { } //Length: 100
	}

	public Kcp(uint conv, Action output) { }

	[CompilerGenerated]
	private void <Flush>g__FlushBuffer|85_1(ref <>c__DisplayClass85_0 unnamed_param_0) { }

	[CompilerGenerated]
	private void <Flush>g__MakeSpace|85_0(int space, ref <>c__DisplayClass85_0 unnamed_param_1) { }

	private void AckPush(uint sn, uint ts) { }

	public uint Check(uint current_) { }

	public void Flush() { }

	public int get_State() { }

	public int get_WaitRcv() { }

	public int get_WaitSnd() { }

	public int Input(byte[] data, int offset, int size) { }

	internal void InsertSegmentInReceiveBuffer(Segment newseg) { }

	private void MoveReceiveBufferDataToReceiveQueue() { }

	internal void ParseAck(uint sn) { }

	private void ParseData(Segment newseg) { }

	private void ParseFastack(uint sn, uint ts) { }

	private void ParseUna(uint una) { }

	public int PeekSize() { }

	public int Receive(byte[] buffer, int len) { }

	private void SegmentDelete(Segment seg) { }

	private Segment SegmentNew() { }

	public int Send(byte[] buffer, int offset, int len) { }

	public void SendClear() { }

	public void SetInterval(uint interval) { }

	public void SetMtu(uint mtu) { }

	public void SetNoDelay(uint nodelay, uint interval = 100, int resend = 0, bool nocwnd = false) { }

	public void SetWindowSize(uint sendWindow, uint receiveWindow) { }

	internal void ShrinkBuf() { }

	public void Update(uint currentTimeMilliSeconds) { }

	private void UpdateAck(int rtt) { }

	private uint WndUnused() { }

}

