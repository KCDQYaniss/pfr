namespace AmplifyMotion;

internal class ParticleState : MotionState
{
	internal class Particle
	{
		public int refCount; //Field offset: 0x10
		public Matrix3x4 prevLocalToWorld; //Field offset: 0x14
		public Matrix3x4 currLocalToWorld; //Field offset: 0x44

		public Particle() { }

	}

	private static HashSet m_uniqueWarnings; //Field offset: 0x0
	public ParticleSystem m_particleSystem; //Field offset: 0x30
	public ParticleSystemRenderer m_renderer; //Field offset: 0x38
	private Mesh m_mesh; //Field offset: 0x40
	private RotationOverLifetimeModule rotationOverLifetime; //Field offset: 0x48
	private RotationBySpeedModule rotationBySpeed; //Field offset: 0x50
	private Particle[] m_particles; //Field offset: 0x58
	private Dictionary m_particleDict; //Field offset: 0x60
	private List m_listToRemove; //Field offset: 0x68
	private Stack m_particleStack; //Field offset: 0x70
	private int m_capacity; //Field offset: 0x78
	private MaterialDesc[] m_sharedMaterials; //Field offset: 0x80
	private bool m_moved; //Field offset: 0x88
	private bool m_wasVisible; //Field offset: 0x89

	private static ParticleState() { }

	public ParticleState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj) { }

	private Mesh CreateBillboardMesh() { }

	private Mesh CreateStretchedBillboardMesh() { }

	internal virtual void Initialize() { }

	private void IssueError(string message) { }

	private void RemoveDeadParticles() { }

	internal virtual void RenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal virtual void UpdateTransform(CommandBuffer updateCB, bool starting) { }

}

