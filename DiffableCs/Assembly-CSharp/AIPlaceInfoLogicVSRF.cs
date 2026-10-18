//Type is in global namespace

public class AIPlaceInfoLogicVSRF : AIPlaceInfoLogic
{
	private List _playersInside; //Field offset: 0x20
	private AIPeriodAction _setInfo; //Field offset: 0x28
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x30
	private bool _isInited; //Field offset: 0x38

	public AIPlaceInfoLogicVSRF() { }

	public virtual void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnPlayerEnter(Player obj) { }

	private void OnPlayerExit(Player obj) { }

	private void SetInfoToVSRF() { }

	private void Update() { }

}

