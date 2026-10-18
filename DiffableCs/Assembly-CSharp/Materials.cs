//Type is in global namespace

public class Materials : MonoBehaviour
{
	public GameObject target; //Field offset: 0x20
	public Color toColor; //Field offset: 0x28
	private Tween colorTween; //Field offset: 0x38
	private Tween emissionTween; //Field offset: 0x40
	private Tween offsetTween; //Field offset: 0x48

	public Materials() { }

	private void Start() { }

	public void ToggleColor() { }

	public void ToggleEmission() { }

	public void ToggleOffset() { }

}

