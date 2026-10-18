namespace MirzaBeig.Scripting.Effects;

public class AttractionParticleAffector : ParticleAffector
{
	[Header("Affector Controls")]
	public float arrivalRadius; //Field offset: 0xC0
	public float arrivedRadius; //Field offset: 0xC4
	private float arrivalRadiusSqr; //Field offset: 0xC8
	private float arrivedRadiusSqr; //Field offset: 0xCC

	public AttractionParticleAffector() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

