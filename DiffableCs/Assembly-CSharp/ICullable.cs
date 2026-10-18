//Type is in global namespace

public interface ICullable
{

	public Vector3 ClearTransformPosition
	{
		 get { } //Length: 0
	}

	public bool CullByDistanceOnly
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float CullDistanceSqr
	{
		 get { } //Length: 0
	}

	public int Index
	{
		 get { } //Length: 0
	}

	public bool IsAutocullVisible
	{
		 get { } //Length: 0
	}

	public bool IsVisible
	{
		 get { } //Length: 0
	}

	public bool IsVisibleByCamera
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public float Radius
	{
		 get { } //Length: 0
	}

	public Vector3 SafeMultithreadedPosition
	{
		 get { } //Length: 0
	}

	public float SqrCameraDistance
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void CustomUpdate() { }

	public Vector3 get_ClearTransformPosition() { }

	public bool get_CullByDistanceOnly() { }

	public float get_CullDistanceSqr() { }

	public int get_Index() { }

	public bool get_IsAutocullVisible() { }

	public bool get_IsVisible() { }

	public bool get_IsVisibleByCamera() { }

	public Vector3 get_Position() { }

	public float get_Radius() { }

	public Vector3 get_SafeMultithreadedPosition() { }

	public float get_SqrCameraDistance() { }

	public void Register() { }

	public void set_CullByDistanceOnly(bool value) { }

	public void set_IsVisibleByCamera(bool value) { }

	public void set_SqrCameraDistance(float value) { }

	public void SetVisibility(bool isVisible) { }

}

