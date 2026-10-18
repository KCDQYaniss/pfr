//Type is in global namespace

public class Gramophone : MonoBehaviour
{
	public SoundBank Bank; //Field offset: 0x20
	public float BlendOverride; //Field offset: 0x28
	public EnvironmentType Environment; //Field offset: 0x2C
	private SoundBank _prevBank; //Field offset: 0x30

	public Gramophone() { }

	private void Update() { }

}

