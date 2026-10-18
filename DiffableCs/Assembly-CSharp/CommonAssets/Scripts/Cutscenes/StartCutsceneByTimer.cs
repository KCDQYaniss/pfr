namespace CommonAssets.Scripts.Cutscenes;

public class StartCutsceneByTimer : MonoBehaviour
{
	public bool timerOn; //Field offset: 0x20
	public string cutsceneId; //Field offset: 0x28
	public float time; //Field offset: 0x30
	[SerializeField]
	private float _timeElapsed; //Field offset: 0x34
	private bool _timerIsUsed; //Field offset: 0x38

	public StartCutsceneByTimer() { }

	private void OnDisable() { }

	public void StartTimer() { }

	public void StopTimer() { }

	private void Update() { }

}

