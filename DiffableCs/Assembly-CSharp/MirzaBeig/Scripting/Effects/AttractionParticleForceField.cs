namespace MirzaBeig.Scripting.Effects;

[AddComponentMenu("Effects/Particle Force Fields/Attraction Particle Force Field")]
public class AttractionParticleForceField : ParticleForceField
{
	[Header("ForceField Controls")]
	[Tooltip("Tether force based on linear inverse particle distance to force field center.")]
	public float arrivalRadius; //Field offset: 0xC0
	[Tooltip("Dead zone from force field center in which no additional force is applied.")]
	public float arrivedRadius; //Field offset: 0xC4
	private float arrivalRadiusSqr; //Field offset: 0xC8
	private float arrivedRadiusSqr; //Field offset: 0xCC

	public AttractionParticleForceField() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

