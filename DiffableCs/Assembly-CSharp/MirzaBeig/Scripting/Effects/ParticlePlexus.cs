namespace MirzaBeig.Scripting.Effects;

[AddComponentMenu("Effects/Particle Plexus")]
[RequireComponent(typeof(ParticleSystem))]
public class ParticlePlexus : MonoBehaviour
{
	public float maxDistance; //Field offset: 0x20
	public int maxConnections; //Field offset: 0x24
	public int maxLineRenderers; //Field offset: 0x28
	[Range(0, 1)]
	public float widthFromParticle; //Field offset: 0x2C
	[Range(0, 1)]
	public float colourFromParticle; //Field offset: 0x30
	[Range(0, 1)]
	public float alphaFromParticle; //Field offset: 0x34
	private ParticleSystem particleSystem; //Field offset: 0x38
	private Particle[] particles; //Field offset: 0x40
	private Vector3[] particlePositions; //Field offset: 0x48
	private Color[] particleColours; //Field offset: 0x50
	private float[] particleSizes; //Field offset: 0x58
	private MainModule particleSystemMainModule; //Field offset: 0x60
	public LineRenderer lineRendererTemplate; //Field offset: 0x68
	private List lineRenderers; //Field offset: 0x70
	private Transform _transform; //Field offset: 0x78
	[Header("General Performance Settings")]
	[Range(0, 1)]
	public float delay; //Field offset: 0x80
	private float timer; //Field offset: 0x84
	public bool alwaysUpdate; //Field offset: 0x88
	private bool visible; //Field offset: 0x89

	public ParticlePlexus() { }

	private void LateUpdate() { }

	private void OnBecameInvisible() { }

	private void OnBecameVisible() { }

	private void OnDisable() { }

	private void Start() { }

}

