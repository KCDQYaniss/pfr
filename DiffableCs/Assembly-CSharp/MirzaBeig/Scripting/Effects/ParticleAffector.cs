namespace MirzaBeig.Scripting.Effects;

public abstract class ParticleAffector : MonoBehaviour
{
	internal struct GetForceParameters
	{
		public float distanceToAffectorCenterSqr; //Field offset: 0x0
		public Vector3 scaledDirectionToAffectorCenter; //Field offset: 0x4
		public Vector3 particlePosition; //Field offset: 0x10

	}

	[Header("Common Controls")]
	public float radius; //Field offset: 0x20
	public float force; //Field offset: 0x24
	public Vector3 offset; //Field offset: 0x28
	private float _radius; //Field offset: 0x34
	private float radiusSqr; //Field offset: 0x38
	private float forceDeltaTime; //Field offset: 0x3C
	private Vector3 transformPosition; //Field offset: 0x40
	private float[] particleSystemExternalForcesMultipliers; //Field offset: 0x50
	public AnimationCurve scaleForceByDistance; //Field offset: 0x58
	private ParticleSystem particleSystem; //Field offset: 0x60
	public List _particleSystems; //Field offset: 0x68
	private int particleSystemsCount; //Field offset: 0x70
	private List particleSystems; //Field offset: 0x78
	private Particle[][] particleSystemParticles; //Field offset: 0x80
	private MainModule[] particleSystemMainModules; //Field offset: 0x88
	private Renderer[] particleSystemRenderers; //Field offset: 0x90
	protected ParticleSystem currentParticleSystem; //Field offset: 0x98
	protected GetForceParameters parameters; //Field offset: 0xA0
	public bool alwaysUpdate; //Field offset: 0xBC

	public float scaledRadius
	{
		 get { } //Length: 197
	}

	protected ParticleAffector() { }

	public void AddParticleSystem(ParticleSystem particleSystem) { }

	protected override void Awake() { }

	public float get_scaledRadius() { }

	protected override Vector3 GetForce() { }

	protected override void LateUpdate() { }

	private void OnApplicationQuit() { }

	protected override void OnDrawGizmosSelected() { }

	protected override void PerParticleSystemSetup() { }

	public void RemoveParticleSystem(ParticleSystem particleSystem) { }

	protected override void Start() { }

	protected override void Update() { }

}

