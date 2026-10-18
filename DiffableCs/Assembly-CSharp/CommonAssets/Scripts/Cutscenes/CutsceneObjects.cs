namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneObjects : MonoBehaviour
{
	public string cutsceneId; //Field offset: 0x20
	public List activateOnStart; //Field offset: 0x28
	public List deactivateOnStart; //Field offset: 0x30
	public List activateOnEnd; //Field offset: 0x38
	public List deactivateOnEnd; //Field offset: 0x40

	public CutsceneObjects() { }

	public void ApplyEnd() { }

	public void ApplyStart() { }

	private void SetObjectsActive(IEnumerable gameObjects, bool active) { }

}

