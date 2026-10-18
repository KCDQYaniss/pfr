namespace MirzaBeig.Scripting.Effects;

public class VortexParticleAffector : ParticleAffector
{
	private Vector3 axisOfRotation; //Field offset: 0xC0
	[Header("Affector Controls")]
	public Vector3 axisOfRotationOffset; //Field offset: 0xCC

	public VortexParticleAffector() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void PerParticleSystemSetup() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	private void UpdateAxisOfRotation() { }

}

