namespace Audio.SpatialSystem.Utils;

public class PositionChangeChecker
{
	private Vector3 _previousListenerPos; //Field offset: 0x10
	private Vector3 _previousSourcePos; //Field offset: 0x1C
	private float _positionChangeThreshold; //Field offset: 0x28

	public PositionChangeChecker() { }

	public bool IsPositionChanged(Vector3 sourcePos, Vector3 listenerPos) { }

	public void SetThreshold(float threshold) { }

}

