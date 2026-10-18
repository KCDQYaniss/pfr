namespace Prism.Demo;

[RequireComponent(typeof(Light))]
public class PrismLightFlicker : MonoBehaviour
{
	[Range(-2, 2)]
	public float offset; //Field offset: 0x20
	[Range(0, 1)]
	public float flickerChance; //Field offset: 0x24
	[Range(0, 5)]
	public float minAliveTime; //Field offset: 0x28
	[Range(0, 5)]
	public float maxAliveTime; //Field offset: 0x2C
	[Range(0, 5)]
	public float flickerSpeed; //Field offset: 0x30
	private float nextTick; //Field offset: 0x34
	private Light m_light; //Field offset: 0x38
	private float initialIntensity; //Field offset: 0x40
	private float targetIntensity; //Field offset: 0x44
	private float lerpAmount; //Field offset: 0x48

	public PrismLightFlicker() { }

	private static float cubicEaseIn(float start, float end, float t) { }

	private void Start() { }

	private void Update() { }

}

