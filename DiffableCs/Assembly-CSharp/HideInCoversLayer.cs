//Type is in global namespace

public class HideInCoversLayer : BaseLogicLayer
{
	private readonly CoverSearchData _coverSearchQuery; //Field offset: 0x90
	private float _nextTimePhrase; //Field offset: 0x98
	private float _timeToRandomStop; //Field offset: 0x9C
	private bool _wasRandomStopped; //Field offset: 0xA0
	private readonly float _civilianCheatVisionDistance; //Field offset: 0xA4
	private readonly float _civilianCheatVisionDistanceSqr; //Field offset: 0xA8
	private readonly AIPeriodAction _cheatingLookTask; //Field offset: 0xB0

	public HideInCoversLayer(BotOwner bot, int priority) { }

	private void CheatingLookUpdate() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool JustCameToCover() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private CustomNavigationPoint UpdateCoverQueryAndFindCover() { }

}

