//Type is in global namespace

public class FinalCutsceneTimer : MonoBehaviour
{
	public List cutscenesWithTimeOut; //Field offset: 0x20
	public float time; //Field offset: 0x28
	public bool timerOn; //Field offset: 0x2C
	private float _timeElapsed; //Field offset: 0x30
	private Action _unsubscribeOnDestroy; //Field offset: 0x38

	public FinalCutsceneTimer() { }

	private void ImmediateExitFromRaid() { }

	private void OnCutSceneStartEvent(CutSceneStartEvent finalExitZoneEvent) { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

}

