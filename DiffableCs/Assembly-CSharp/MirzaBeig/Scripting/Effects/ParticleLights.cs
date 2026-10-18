namespace MirzaBeig.Scripting.Effects;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleLights : MonoBehaviour
{
	private ParticleSystem ps; //Field offset: 0x20
	private List lights; //Field offset: 0x28
	public float scale; //Field offset: 0x30
	[Range(0, 8)]
	public float intensity; //Field offset: 0x34
	public Color colour; //Field offset: 0x38
	[Range(0, 1)]
	public float colourFromParticle; //Field offset: 0x48
	public LightShadows shadows; //Field offset: 0x4C
	private GameObject template; //Field offset: 0x50

	public ParticleLights() { }

	private void Awake() { }

	private void LateUpdate() { }

	private void Start() { }

	private void Update() { }

}

