//Type is in global namespace

public class CompassArrow : MonoBehaviour
{
	[SerializeField]
	private BetterSpring _spring; //Field offset: 0x20
	public Vector3 NorthDirection; //Field offset: 0x28
	private Transform _transform; //Field offset: 0x38
	private float _previousAngle; //Field offset: 0x40
	private float _eulerTarget; //Field offset: 0x44

	public CompassArrow() { }

	public int PanelValue() { }

	private void Start() { }

	private void Update() { }

}

