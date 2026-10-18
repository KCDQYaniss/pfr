//Type is in global namespace

public class Trigger : MonoBehaviour
{
	[SerializeField]
	private float _impactForceThreshold; //Field offset: 0x20

	private float ImpactForceThresholdSqr
	{
		private get { } //Length: 10
	}

	public Trigger() { }

	private float get_ImpactForceThresholdSqr() { }

	private void OnCollisionEnter(Collision c) { }

	public void TriggerDestruction(Vector3 triggerPosition, float magnitude) { }

}

