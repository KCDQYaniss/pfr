//Type is in global namespace

public class TimeScaler : MonoBehaviour
{
	public bool IgnoreFixedUpdates; //Field offset: 0x20
	private float _initialFixedDeltaTime; //Field offset: 0x24
	public Vector2 TimeScaleRange; //Field offset: 0x28
	[Range(0.01, 1)]
	public float TimeScale; //Field offset: 0x30

	public TimeScaler() { }

	private void Awake() { }

}

