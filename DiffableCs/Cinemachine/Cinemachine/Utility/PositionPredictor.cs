namespace Cinemachine.Utility;

public class PositionPredictor
{
	private Vector3 m_Velocity; //Field offset: 0x10
	private Vector3 m_SmoothDampVelocity; //Field offset: 0x1C
	private Vector3 m_Pos; //Field offset: 0x28
	private bool m_HavePos; //Field offset: 0x34
	public float Smoothing; //Field offset: 0x38

	public PositionPredictor() { }

	public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) { }

	public void ApplyTransformDelta(Vector3 positionDelta) { }

	public bool IsEmpty() { }

	public Vector3 PredictPosition(float lookaheadTime) { }

	public Vector3 PredictPositionDelta(float lookaheadTime) { }

	public void Reset() { }

}

