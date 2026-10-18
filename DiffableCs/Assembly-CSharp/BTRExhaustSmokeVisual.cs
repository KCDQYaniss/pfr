//Type is in global namespace

public class BTRExhaustSmokeVisual : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _particleSystem; //Field offset: 0x20

	public BTRExhaustSmokeVisual() { }

	public void SetProperties(Vector2 lifetimeMinMax, Vector2 sizeMinMax, float rate, float speed, Color color) { }

	public void SetProperties(Vector2 lifetimeMinMax, float rate) { }

	private void SetProperties(MinMaxCurve lifetime, float rate) { }

	private void SetProperties(MinMaxCurve lifetime, MinMaxCurve size, float rate, float speed, Color color) { }

}

