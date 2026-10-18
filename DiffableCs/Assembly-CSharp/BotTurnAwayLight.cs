//Type is in global namespace

public class BotTurnAwayLight : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public BotTurnAwayLight <>4__this; //Field offset: 0x10
		public Func posToTurnAway; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <Activate>b__0() { }

	}

	private const float MAX_TURN_AWAY_TIME = 4; //Field offset: 0x0
	private bool _isActive; //Field offset: 0x18
	private float _startTime; //Field offset: 0x1C
	private Func _posToTurnAway; //Field offset: 0x20
	private ITimer _timer; //Field offset: 0x28

	public bool IsActive
	{
		 get { } //Length: 97
	}

	public BotTurnAwayLight(BotOwner owner) { }

	public void Activate(Func posToTurnAway, float delay = 0) { }

	public bool get_IsActive() { }

	public void Update() { }

}

