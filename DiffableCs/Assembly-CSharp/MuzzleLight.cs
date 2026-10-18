//Type is in global namespace

[RequireComponent(typeof(Light))]
public class MuzzleLight : MonoBehaviour
{
	[MinMaxVec2(0, 10, -1)]
	public Vector2 Range; //Field offset: 0x20
	public Light[] Lights; //Field offset: 0x28
	public AnimationCurve LightIntensityCurve; //Field offset: 0x30

	public MuzzleLight() { }

	internal void OnShot() { }

	public void SetIntensity(float intensity) { }

	public void Start() { }

}

