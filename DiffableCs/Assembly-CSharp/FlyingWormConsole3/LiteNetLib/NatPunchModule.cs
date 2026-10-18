namespace FlyingWormConsole3.LiteNetLib;

public sealed class NatPunchModule
{
	private class NatIntroduceRequestPacket
	{
		[CompilerGenerated]
		private IPEndPoint <Internal>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <Token>k__BackingField; //Field offset: 0x18

		public IPEndPoint Internal
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string Token
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public NatIntroduceRequestPacket() { }

		[CompilerGenerated]
		public IPEndPoint get_Internal() { }

		[CompilerGenerated]
		public string get_Token() { }

		[CompilerGenerated]
		public void set_Internal(IPEndPoint value) { }

		[CompilerGenerated]
		public void set_Token(string value) { }

	}

	private class NatIntroduceResponsePacket
	{
		[CompilerGenerated]
		private IPEndPoint <Internal>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private IPEndPoint <External>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <Token>k__BackingField; //Field offset: 0x20

		public IPEndPoint External
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public IPEndPoint Internal
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string Token
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public NatIntroduceResponsePacket() { }

		[CompilerGenerated]
		public IPEndPoint get_External() { }

		[CompilerGenerated]
		public IPEndPoint get_Internal() { }

		[CompilerGenerated]
		public string get_Token() { }

		[CompilerGenerated]
		public void set_External(IPEndPoint value) { }

		[CompilerGenerated]
		public void set_Internal(IPEndPoint value) { }

		[CompilerGenerated]
		public void set_Token(string value) { }

	}

	private class NatPunchPacket
	{
		[CompilerGenerated]
		private string <Token>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <IsExternal>k__BackingField; //Field offset: 0x18

		public bool IsExternal
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public string Token
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public NatPunchPacket() { }

		[CompilerGenerated]
		public bool get_IsExternal() { }

		[CompilerGenerated]
		public string get_Token() { }

		[CompilerGenerated]
		public void set_IsExternal(bool value) { }

		[CompilerGenerated]
		public void set_Token(string value) { }

	}

	private struct RequestEventData
	{
		public IPEndPoint LocalEndPoint; //Field offset: 0x0
		public IPEndPoint RemoteEndPoint; //Field offset: 0x8
		public string Token; //Field offset: 0x10

	}

	private struct SuccessEventData
	{
		public IPEndPoint TargetEndPoint; //Field offset: 0x0
		public NatAddressType Type; //Field offset: 0x8
		public string Token; //Field offset: 0x10

	}

	public const int MaxTokenLength = 256; //Field offset: 0x0
	private readonly NetSocket _socket; //Field offset: 0x10
	private readonly Queue _requestEvents; //Field offset: 0x18
	private readonly Queue _successEvents; //Field offset: 0x20
	private readonly NetDataReader _cacheReader; //Field offset: 0x28
	private readonly NetDataWriter _cacheWriter; //Field offset: 0x30
	private readonly NetPacketProcessor _netPacketProcessor; //Field offset: 0x38
	private INatPunchListener _natPunchListener; //Field offset: 0x40

	internal NatPunchModule(NetSocket socket) { }

	public void Init(INatPunchListener listener) { }

	public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo) { }

	private void OnNatIntroductionRequest(NatIntroduceRequestPacket req, IPEndPoint senderEndPoint) { }

	private void OnNatIntroductionResponse(NatIntroduceResponsePacket req) { }

	private void OnNatPunch(NatPunchPacket req, IPEndPoint senderEndPoint) { }

	public void PollEvents() { }

	internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet) { }

	private void Send(T packet, IPEndPoint target) { }

	public void SendNatIntroduceRequest(string host, int port, string additionalInfo) { }

	public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo) { }

}

