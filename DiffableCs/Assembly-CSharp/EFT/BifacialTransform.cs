namespace EFT;

public class BifacialTransform
{
	[SerializeField]
	public Transform Original; //Field offset: 0x10
	private Func _positionImitator; //Field offset: 0x18
	private Action _positionSetImitator; //Field offset: 0x20
	private Func _rotationImitator; //Field offset: 0x28
	private Action _rotationSetImitator; //Field offset: 0x30
	private Action _positionAndRotationSetImitator; //Field offset: 0x38
	private Func _localPositionImitator; //Field offset: 0x40
	private Action _localPositionSetImitator; //Field offset: 0x48
	private Func _localRotationImitator; //Field offset: 0x50
	private Action _localRotationSetImitator; //Field offset: 0x58
	private Func _forwardImitator; //Field offset: 0x60
	private Func _upImitator; //Field offset: 0x68
	private Func _rightImitator; //Field offset: 0x70
	private Func _eulerAnglesImitator; //Field offset: 0x78
	private Func _transformPointImitator; //Field offset: 0x80
	private Func _inverseTransformVectorImitator; //Field offset: 0x88
	private Func _transformVectorImitator; //Field offset: 0x90
	private Func _inverseTransformPointImitator; //Field offset: 0x98
	private Action _lookAtImitator; //Field offset: 0xA0
	private bool _useImitation; //Field offset: 0xA8
	private bool _accumulatePositionAndRotation; //Field offset: 0xA9
	private Vector3 _accumulatedPosition; //Field offset: 0xAC
	private Quaternion _accumulatedRotation; //Field offset: 0xB8

	public bool AccumulatePositionAndRotation
	{
		 get { } //Length: 8
		 set { } //Length: 88
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 126
	}

	public Vector3 forward
	{
		 get { } //Length: 98
	}

	public Vector3 localPosition
	{
		 get { } //Length: 207
		 set { } //Length: 188
	}

	public Quaternion localRotation
	{
		 get { } //Length: 183
		 set { } //Length: 170
	}

	public Vector3 position
	{
		 get { } //Length: 255
		 set { } //Length: 227
	}

	public Vector3 right
	{
		 get { } //Length: 98
	}

	public Quaternion rotation
	{
		 get { } //Length: 220
		 set { } //Length: 198
	}

	public Vector3 up
	{
		 get { } //Length: 98
	}

	public bool UseImitation
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public BifacialTransform() { }

	public void ApplyAccumulatedPositionAndRotation() { }

	public void CopyImitators(BifacialTransform donor) { }

	public bool get_AccumulatePositionAndRotation() { }

	public Vector3 get_eulerAngles() { }

	public Vector3 get_forward() { }

	public Vector3 get_localPosition() { }

	public Quaternion get_localRotation() { }

	public Vector3 get_position() { }

	public Vector3 get_right() { }

	public Quaternion get_rotation() { }

	public Vector3 get_up() { }

	public bool get_UseImitation() { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void set_AccumulatePositionAndRotation(bool value) { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	public void set_position(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	public void set_UseImitation(bool value) { }

	public void SetImitators(Func positionImitator, Action positionSetImitator, Func rotationImitator, Action rotationSetImitator, Action positionAndRotationSetImitator, Func localPositionImitator, Action localPositionSetImitator, Func localRotationImitator, Action localRotationSetImitator, Func forwardImitator, Func upImitator, Func rightImitator, Func eulerAnglesImitator, Func transformPointImitator, Func inverseTransformPointImitator, Func transformVectorImitator, Func inverseTransformVectorImitator, Action lookAtImitator) { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	private void SetPositionAndRotationInternal(Vector3 position, Quaternion rotation) { }

	public void SyncImitators() { }

	public void SyncOriginal() { }

	public Vector3 TransformPoint(Vector3 position) { }

	public Vector3 TransformVector(Vector3 vector) { }

}

