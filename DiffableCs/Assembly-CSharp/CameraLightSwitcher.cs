//Type is in global namespace

public class CameraLightSwitcher : MonoBehaviour
{
	public List Lights; //Field offset: 0x20

	public CameraLightSwitcher() { }

	protected override void OnEnable() { }

	protected override void OnPostRender() { }

	protected override void OnPreCull() { }

	protected void TurnLights(bool on) { }

}

