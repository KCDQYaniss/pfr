//Type is in global namespace

public class Seasons
{
	private sealed class SeasonsLogger : AbstractLogger
	{
		private static SeasonsLogger _instance; //Field offset: 0x0

		public static SeasonsLogger Instance
		{
			 get { } //Length: 311
		}

		private SeasonsLogger() { }

		public static SeasonsLogger get_Instance() { }

	}

	[CompilerGenerated]
	private static Action OnInitialized; //Field offset: 0x0

	public static event Action OnInitialized
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	[CanBeNull]
	public static ISeasonsController Controller
	{
		 get { } //Length: 241
	}

	public static AbstractLogger Logger
	{
		 get { } //Length: 311
	}

	public Seasons() { }

	[CompilerGenerated]
	public static void add_OnInitialized(Action value) { }

	public static ISeasonsController get_Controller() { }

	public static AbstractLogger get_Logger() { }

	protected static void RaiseOnInitializedEvent(ISeasonsController controller) { }

	[CompilerGenerated]
	public static void remove_OnInitialized(Action value) { }

}

