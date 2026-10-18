//Type is in global namespace

public class ChangeObjectsBySide : MonoBehaviour
{
	public string cutsceneId; //Field offset: 0x20
	public List _bearObjectsNames; //Field offset: 0x28
	public List _usecObjectsNames; //Field offset: 0x30
	private Action _unsubscribeOnDestroy; //Field offset: 0x38

	public ChangeObjectsBySide() { }

	private void OnDestroy() { }

	private void Start() { }

	private void StartCutsceneGroupEventHandler(CutSceneStartEvent startEvent) { }

}

