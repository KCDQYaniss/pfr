namespace FlyingWormConsole3.LiteNetLib;

public class EventBasedNatPunchListener : INatPunchListener
{
	internal sealed class OnNatIntroductionRequest : MulticastDelegate
	{

		public OnNatIntroductionRequest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token) { }

	}

	internal sealed class OnNatIntroductionSuccess : MulticastDelegate
	{

		public OnNatIntroductionSuccess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPEndPoint targetEndPoint, NatAddressType type, string token, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPEndPoint targetEndPoint, NatAddressType type, string token) { }

	}

	[CompilerGenerated]
	private OnNatIntroductionRequest NatIntroductionRequest; //Field offset: 0x10
	[CompilerGenerated]
	private OnNatIntroductionSuccess NatIntroductionSuccess; //Field offset: 0x18

	public event OnNatIntroductionRequest NatIntroductionRequest
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNatIntroductionSuccess NatIntroductionSuccess
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public EventBasedNatPunchListener() { }

	[CompilerGenerated]
	public void add_NatIntroductionRequest(OnNatIntroductionRequest value) { }

	[CompilerGenerated]
	public void add_NatIntroductionSuccess(OnNatIntroductionSuccess value) { }

	private override void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token) { }

	private override void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token) { }

	[CompilerGenerated]
	public void remove_NatIntroductionRequest(OnNatIntroductionRequest value) { }

	[CompilerGenerated]
	public void remove_NatIntroductionSuccess(OnNatIntroductionSuccess value) { }

}

