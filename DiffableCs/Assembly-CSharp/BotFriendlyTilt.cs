//Type is in global namespace

public class BotFriendlyTilt : BotData
{
	private class TiltPLayerRequests
	{
		public int Times; //Field offset: 0x10
		public float LastTime; //Field offset: 0x14

		public TiltPLayerRequests() { }

	}

	private const float CHANCE_MUMBLE_TILT = 111; //Field offset: 0x0
	private const float PLAYER_ANSWER_PERIOD_AFTER_MAX = 6; //Field offset: 0x0
	private const int PLAYER_ANSWER_TIMES_MAX = 6; //Field offset: 0x0
	private const float SIDE_TILT_PERIOD = 0.5; //Field offset: 0x0
	private const int TILT_LENGHT = 4; //Field offset: 0x0
	private readonly float[] _times; //Field offset: 0x18
	private bool prevTiltSide; //Field offset: 0x20
	private int _tiltIndex; //Field offset: 0x24
	private bool _tilting; //Field offset: 0x28
	private IPlayer _lookTo; //Field offset: 0x30
	private readonly Dictionary _timesRequests; //Field offset: 0x38

	public BotFriendlyTilt(BotOwner owner) { }

	public void Activate() { }

	private void ApplyRequest(IPlayer player) { }

	public void Dispose() { }

	public void EndTilt() { }

	public bool HaveActions() { }

	public void ManualUpdate() { }

	private void OnPeaceChange(bool isPeace) { }

	private void PlayerDeadOrUnspawn(Player player) { }

	public void StartTilt(BotsPairData closest) { }

	public void StartTilt(IPlayer target) { }

	public void TryAddRequest(IPlayer player) { }

	private void TryUnsubscribe() { }

}

