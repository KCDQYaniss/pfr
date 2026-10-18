namespace MirzaBeig.Scripting.Effects;

public abstract class ParticleForceField : MonoBehaviour
{
	internal struct GetForceParameters
	{
		public float distanceToForceFieldCenterSqr; //Field offset: 0x0
		public Vector3 scaledDirectionToForceFieldCenter; //Field offset: 0x4
		public Vector3 particlePosition; //Field offset: 0x10

	}

	[Header("Common Controls")]
	[Tooltip("Force field spherical range.")]
	public float radius; //Field offset: 0x20
	[Tooltip("Maximum baseline force.")]
	public float force; //Field offset: 0x24
	[Tooltip("Internal force field position offset.")]
	public Vector3 center; //Field offset: 0x28
	private float _radius; //Field offset: 0x34
	private float radiusSqr; //Field offset: 0x38
	private float forceDeltaTime; //Field offset: 0x3C
	private Vector3 transformPosition; //Field offset: 0x40
	private float[] particleSystemExternalForcesMultipliers; //Field offset: 0x50
	[Tooltip("Force scale as determined by distance to individual particles.")]
	public AnimationCurve forceOverDistance; //Field offset: 0x58
	private ParticleSystem particleSystem; //Field offset: 0x60
	[Tooltip("If nothing no particle systems are assigned, this force field will operate globally on ALL particle systems in the scene (NOT recommended).\n\nIf attached to a particle system, the force field will operate only on that system.\n\nIf specific particle systems are assigned, then the force field will operate on those systems only, even if attached to a particle system.")]
	public List _particleSystems; //Field offset: 0x68
	private int particleSystemsCount; //Field offset: 0x70
	private List particleSystems; //Field offset: 0x78
	private Particle[][] particleSystemParticles; //Field offset: 0x80
	private MainModule[] particleSystemMainModules; //Field offset: 0x88
	private Renderer[] particleSystemRenderers; //Field offset: 0x90
	protected ParticleSystem currentParticleSystem; //Field offset: 0x98
	protected GetForceParameters parameters; //Field offset: 0xA0
	[Tooltip("If TRUE, update even if target particle system(s) are invisible/offscreen.\n\nIf FALSE, update only if particles of the target system(s) are visible/onscreen.")]
	public bool alwaysUpdate; //Field offset: 0xBC

	public float scaledRadius
	{
		 get { } //Length: 197
	}

	protected ParticleForceField() { }

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

