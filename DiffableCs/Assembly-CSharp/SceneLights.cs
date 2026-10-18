//Type is in global namespace

public class SceneLights : MonoBehaviour
{
	public static List AllLights; //Field offset: 0x0
	[SerializeField]
	private Light[] _lights; //Field offset: 0x20

	private static SceneLights() { }

	public SceneLights() { }

	[CompilerGenerated]
	private bool <RecacheLights>b__3_0(Light x) { }

	private void Awake() { }

	public void RecacheLights() { }

}

