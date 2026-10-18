namespace Audio;

public interface ITransformTracker
{

	public bool IsPositionTracked
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public bool get_IsPositionTracked() { }

	public Vector3 get_Position() { }

	public void StartTracking(Transform tracker, Vector3 positionOffset = null) { }

	public void StopTracking() { }

	public void UpdatePosition() { }

}

