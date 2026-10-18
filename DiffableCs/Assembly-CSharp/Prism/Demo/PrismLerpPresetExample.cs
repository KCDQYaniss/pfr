namespace Prism.Demo;

public class PrismLerpPresetExample : MonoBehaviour
{
	private PrismEffects prism; //Field offset: 0x20
	[Header("This script lerps a PRISM preset based on distance to the camera")]
	[Header("NOTE: This is an example script, you should only have one per scene")]
	public float maxDistance; //Field offset: 0x28
	public float t; //Field offset: 0x2C
	[Tooltip("The Prism-Preset to lerp TO")]
	public PrismPreset target; //Field offset: 0x30
	public AnimationCurve cameraDistanceCurve; //Field offset: 0x38

	public PrismLerpPresetExample() { }

	private void Start() { }

	private void Update() { }

}

