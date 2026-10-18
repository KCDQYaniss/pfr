//Type is in global namespace

public class Gag
{
	private const float MIN_RADIUS_INTERPOLATION_DISTANCE = 5; //Field offset: 0x0
	private const float MIN_RADIUS_INTERPOLATION_DISTANCE_SQR = 25; //Field offset: 0x0
	private const float DISTANCE_TOWARDS_PLAYER = 0.2; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x10
	public double EndTime; //Field offset: 0x20
	private Vector2 _radius; //Field offset: 0x28
	private float _rolloff; //Field offset: 0x30
	private float _sqrRolloff; //Field offset: 0x34

	public bool IsActive
	{
		 get { } //Length: 87
	}

	public Vector2 Radius
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float Rolloff
	{
		 get { } //Length: 6
		 set { } //Length: 23
	}

	public Gag() { }

	public bool get_IsActive() { }

	public Vector2 get_Radius() { }

	public float get_Rolloff() { }

	public bool IsChoked(Vector3 newPosition, Vector3 listener, float sqrDistance) { }

	public void Reset() { }

	public void set_Radius(Vector2 value) { }

	public void set_Rolloff(float value) { }

}

