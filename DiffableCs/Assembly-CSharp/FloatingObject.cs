//Type is in global namespace

public class FloatingObject : UpdateInEditorSystemComponent
{
	[SerializeField]
	private float _angle; //Field offset: 0x20
	[SerializeField]
	private Vector3 _buoyancy; //Field offset: 0x24
	[SerializeField]
	private float _angleAmplitude; //Field offset: 0x30
	[SerializeField]
	private float _buoyancyAmplitude; //Field offset: 0x34
	private Vector3 _savedPosition; //Field offset: 0x38
	private Quaternion _savedRotation; //Field offset: 0x44
	private float _rotationFloatingTime; //Field offset: 0x54
	private float _positionFloatingTime; //Field offset: 0x58
	private float _seed; //Field offset: 0x5C

	public FloatingObject() { }

	public virtual void ManualUpdate(float dt) { }

	private void SetPositionAndRotation(float positionFloatingTime, float rotationFloatingTime) { }

	private void Start() { }

}

