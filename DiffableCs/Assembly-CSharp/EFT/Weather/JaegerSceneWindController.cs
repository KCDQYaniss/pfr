namespace EFT.Weather;

public class JaegerSceneWindController : MonoBehaviour
{
	public LocationScene LocationScene; //Field offset: 0x20
	public WindController WindController; //Field offset: 0x28
	public Vector2 WindDirection; //Field offset: 0x30

	public JaegerSceneWindController() { }

	private void Start() { }

}

