namespace EFT;

internal sealed class TrafficCollectScenario : MonoBehaviour
{
	private struct Data
	{
		public TimeSpan TimeSpan; //Field offset: 0x0
		public TrafficState GameSent; //Field offset: 0x8
		public TrafficState GameReceived; //Field offset: 0x14
		public TrafficState VoipSent; //Field offset: 0x20
		public TrafficState VoipReceived; //Field offset: 0x2C

	}

	public sealed class Logger : AbstractLogger
	{

		internal Logger() { }

	}

	private IGame _game; //Field offset: 0x20
	private TimeSpan _step; //Field offset: 0x28
	private Logger _logger; //Field offset: 0x30
	private DateTime _dateTime; //Field offset: 0x38
	private readonly List _states; //Field offset: 0x40
	private Data _last; //Field offset: 0x48

	private static TimeSpan DefaultTimeSpan
	{
		private get { } //Length: 137
	}

	public TrafficCollectScenario() { }

	private Data Collect() { }

	private static TrafficState Collect(TrafficCounter counter) { }

	internal static TrafficCollectScenario Create(IGame game, Nullable step = null, Logger logger = null) { }

	private static TimeSpan get_DefaultTimeSpan() { }

	public TrafficData TrafficData() { }

	private void Update() { }

}

