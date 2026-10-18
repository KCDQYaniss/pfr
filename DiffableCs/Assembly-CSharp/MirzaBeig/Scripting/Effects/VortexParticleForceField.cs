namespace MirzaBeig.Scripting.Effects;

[AddComponentMenu("Effects/Particle Force Fields/Vortex Particle Force Field")]
public class VortexParticleForceField : ParticleForceField
{
	private Vector3 axisOfRotation; //Field offset: 0xC0
	[Header("ForceField Controls")]
	[Tooltip("Internal offset for the axis of rotation.\n\nUseful if the force field and particle system are on the same game object, and you need a seperate rotation for the system, and the affector, but don't want to make the two different game objects.")]
	public Vector3 axisOfRotationOffset; //Field offset: 0xCC

	public VortexParticleForceField() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void PerParticleSystemSetup() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	private void UpdateAxisOfRotation() { }

}

