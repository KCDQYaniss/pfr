//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(PrismEffects))]
public class PrismSetDofFocusPointToCameraRay : MonoBehaviour
{
	public float lerpSpeed; //Field offset: 0x20
	public float sphereRadius; //Field offset: 0x24
	public GameObject currentHitObject; //Field offset: 0x28

	public PrismSetDofFocusPointToCameraRay() { }

	private void Update() { }

}

