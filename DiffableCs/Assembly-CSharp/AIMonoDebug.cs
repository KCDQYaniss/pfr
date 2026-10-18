//Type is in global namespace

public class AIMonoDebug : MonoBehaviour
{
	private BotsController _botsController; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsInited>k__BackingField; //Field offset: 0x28

	public private bool IsInited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotZoneGroupsDictionary ZoneGroups
	{
		 get { } //Length: 39
	}

	public AIMonoDebug() { }

	[CompilerGenerated]
	public bool get_IsInited() { }

	public BotZoneGroupsDictionary get_ZoneGroups() { }

	public void Init(BotsController bController) { }

	[CompilerGenerated]
	private void set_IsInited(bool value) { }

}

