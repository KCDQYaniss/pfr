namespace EFT.Hideout;

public class FreeSpaceCameraMoveSettings
{
	[SerializeField]
	private float _moveSpeed; //Field offset: 0x10
	[SerializeField]
	private float _mouseRotationSpeed; //Field offset: 0x14
	[SerializeField]
	private float _autoRotationSpeed; //Field offset: 0x18
	[SerializeField]
	private float _screenEdgeDelta; //Field offset: 0x1C
	[SerializeField]
	private Transform _bounds; //Field offset: 0x20
	[SerializeField]
	private Vector3 _defaultVirtualCameraLocalPosition; //Field offset: 0x28
	[SerializeField]
	private Vector3 _defaultVirtualCameraLocalRotation; //Field offset: 0x34
	private Transform _cachedBounds; //Field offset: 0x40
	private Nullable _xCameraBorder; //Field offset: 0x48
	private Nullable _zCameraBorder; //Field offset: 0x54

	public float AutoRotationSpeed
	{
		 get { } //Length: 6
	}

	public Vector3 DefaultVirtualCameraLocalPosition
	{
		 get { } //Length: 19
	}

	public Vector3 DefaultVirtualCameraLocalRotation
	{
		 get { } //Length: 19
	}

	public float MouseRotationSpeed
	{
		 get { } //Length: 6
	}

	public float MoveSpeed
	{
		 get { } //Length: 6
	}

	public float ScreenEdgeDelta
	{
		 get { } //Length: 6
	}

	public FreeSpaceCameraMoveSettings() { }

	public float get_AutoRotationSpeed() { }

	public Vector3 get_DefaultVirtualCameraLocalPosition() { }

	public Vector3 get_DefaultVirtualCameraLocalRotation() { }

	public float get_MouseRotationSpeed() { }

	public float get_MoveSpeed() { }

	public float get_ScreenEdgeDelta() { }

	private ValueTuple GetBounds(ref Nullable boundValue, float localPosition, float localScale) { }

	public ValueTuple GetXCameraBorder() { }

	public ValueTuple GetZCameraBorder() { }

	private void UpdateBounds() { }

}

