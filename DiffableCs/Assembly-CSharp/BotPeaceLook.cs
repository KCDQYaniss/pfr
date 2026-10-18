//Type is in global namespace

public class BotPeaceLook : BotData
{
	private const float AIM_SDIST_REPLY = 400; //Field offset: 0x0
	private const float STANDARD_LOOK_PERIOD = 3; //Field offset: 0x0
	private const float STANDARD_AIM_REQUEST_CHANCE_100 = 50; //Field offset: 0x0
	private bool _doing; //Field offset: 0x18
	private IPlayer _lookTo; //Field offset: 0x20
	private float _aimEndTime; //Field offset: 0x28

	public BotPeaceLook(BotOwner owner) { }

	public void Activate() { }

	public void Dispose() { }

	public void EndAim() { }

	public bool HaveActions() { }

	public void ManualUpdate() { }

	private void OnPeaceChange(bool isPeace) { }

	public void StartLook(BotsPairData closest) { }

	public void StartLook(IPlayer lookTo) { }

	public void TryAddRequest(IPlayer player) { }

}

