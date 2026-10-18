namespace Vuplex.WebView;

public class StandaloneClientCertificateRequestedEventArgs : EventArgs
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__6_0(StandaloneX509Certificate c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public CertificateRequestMessage message; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal StandaloneX509Certificate <.ctor>b__0(MessageCertificate c) { }

	}

	public readonly StandaloneX509Certificate[] Certificates; //Field offset: 0x10
	public readonly string Host; //Field offset: 0x18
	public readonly int Port; //Field offset: 0x20
	public readonly bool IsProxy; //Field offset: 0x24
	private Action _selectCallback; //Field offset: 0x28
	private int _id; //Field offset: 0x30

	private StandaloneClientCertificateRequestedEventArgs(CertificateRequestMessage message, Action selectCallback) { }

	internal static StandaloneClientCertificateRequestedEventArgs FromMessageJson(string serializedMessage, Action selectCallback) { }

	public void Select(StandaloneX509Certificate certificate) { }

	public virtual string ToString() { }

}

