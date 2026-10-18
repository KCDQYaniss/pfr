namespace EFT.Network.Quality;

public class NetworkQualityUnionWatcher
{
	internal sealed class KickDelegate : MulticastDelegate
	{

		public KickDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkQualityParam networkQualityParam, EDisconnectionCode disconnectionCode, float time, float period, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetworkQualityParam networkQualityParam, EDisconnectionCode disconnectionCode, float time, float period) { }

	}

	private NetworkConnection _connection; //Field offset: 0x10
	private KickDelegate _kickByQualityCallback; //Field offset: 0x18
	private NetworkQualityWatcher _pingWatcher; //Field offset: 0x20
	private NetworkQualityWatcher _lossWatcher; //Field offset: 0x28

	public bool Started
	{
		 set { } //Length: 132
	}

	public NetworkQualityUnionWatcher(NetworkConnection connection, NetworkQualityParams networkQualityParams, KickDelegate callback) { }

	public void ManualUpdate(float time) { }

	public void set_Started(bool value) { }

	private void WatchNetworkQuality(float time, int rtt, int loss) { }

}

