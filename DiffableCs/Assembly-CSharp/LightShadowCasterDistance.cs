//Type is in global namespace

[RequireComponent(typeof(Light))]
public class LightShadowCasterDistance : MonoBehaviour
{
	[SerializeField]
	private float _cullDistance; //Field offset: 0x20
	private Light _light; //Field offset: 0x28
	private float[] _distances; //Field offset: 0x30

	public LightShadowCasterDistance() { }

	private void Update() { }

	private void UpdateDistances() { }

}

