//Type is in global namespace

public class FlickeringLights : MonoBehaviour
{
	public float MinIntensity; //Field offset: 0x20
	public float MaxIntensity; //Field offset: 0x24
	public float FlickerRate; //Field offset: 0x28
	private float randOffset; //Field offset: 0x2C
	private Light _light; //Field offset: 0x30

	public FlickeringLights() { }

	private void Start() { }

	private void Update() { }

}

