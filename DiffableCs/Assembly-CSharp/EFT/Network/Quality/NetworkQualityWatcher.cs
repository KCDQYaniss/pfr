namespace EFT.Network.Quality;

internal sealed class NetworkQualityWatcher
{
	internal sealed class Core
	{
		public Nullable TrackingTimer; //Field offset: 0x10
		public Nullable KickTimer; //Field offset: 0x18
		public Nullable PauseTimer; //Field offset: 0x20
		public float Pause; //Field offset: 0x28

		public Core() { }

	}

	internal sealed class KickCommand
	{
		[CompilerGenerated]
		private float <Time>k__BackingField; //Field offset: 0x10

		public float Time
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public KickCommand() { }

		[CompilerGenerated]
		public float get_Time() { }

		[CompilerGenerated]
		public void set_Time(float value) { }

	}

	private readonly NetworkQualityParam _networkQualityParams; //Field offset: 0x10
	private readonly Core _core; //Field offset: 0x18
	private bool _started; //Field offset: 0x20

	private Nullable KickTimer
	{
		private get { } //Length: 27
		private set { } //Length: 27
	}

	public NetworkQualityParam NetworkQualityParam
	{
		 get { } //Length: 5
	}

	private float Pause
	{
		private get { } //Length: 28
		private set { } //Length: 28
	}

	private Nullable PauseTimer
	{
		private get { } //Length: 27
		private set { } //Length: 27
	}

	internal bool Started
	{
		internal get { } //Length: 5
		internal set { } //Length: 63
	}

	private Nullable TrackingTimer
	{
		private get { } //Length: 27
		private set { } //Length: 27
	}

	internal NetworkQualityWatcher(NetworkQualityParam networkQualityParams, Core core = null) { }

	private Nullable get_KickTimer() { }

	public NetworkQualityParam get_NetworkQualityParam() { }

	private float get_Pause() { }

	private Nullable get_PauseTimer() { }

	internal bool get_Started() { }

	private Nullable get_TrackingTimer() { }

	private void set_KickTimer(Nullable value) { }

	private void set_Pause(float value) { }

	private void set_PauseTimer(Nullable value) { }

	internal void set_Started(bool value) { }

	private void set_TrackingTimer(Nullable value) { }

	private KickCommand TryKick(float now) { }

	private void TryRestore(float now) { }

	internal KickCommand Update(float now, int rtt) { }

}

