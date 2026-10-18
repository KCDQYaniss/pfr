//Type is in global namespace

public class CinemachineTouchInputMapper : MonoBehaviour
{
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX; //Field offset: 0x20
	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY; //Field offset: 0x24
	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo; //Field offset: 0x28
	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo; //Field offset: 0x30

	public CinemachineTouchInputMapper() { }

	private float GetInputAxis(string axisName) { }

	private void Start() { }

}

