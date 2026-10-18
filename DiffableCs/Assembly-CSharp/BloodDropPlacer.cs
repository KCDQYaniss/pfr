//Type is in global namespace

public class BloodDropPlacer
{
	private const float ARTERIAL_BLEEDING_FACTOR = 2; //Field offset: 0x0
	private Vector2 _startScaleDimension; //Field offset: 0x10
	private Vector2 _endScaleDimension; //Field offset: 0x18
	private Vector2 _dropCountRange; //Field offset: 0x20
	private Vector2 _maxRayLength; //Field offset: 0x28
	private Vector2 _startXdistribution; //Field offset: 0x30
	private Vector2 _startYdistribution; //Field offset: 0x38
	private Vector2 _endXdistribution; //Field offset: 0x40
	private Vector2 _endYdistribution; //Field offset: 0x48
	private readonly float _cos45; //Field offset: 0x50
	private readonly float _cathetus; //Field offset: 0x54
	private float _offGlassScaleMultiplier; //Field offset: 0x58
	private float _currentScaleMultiplier; //Field offset: 0x5C

	public BloodDropPlacer() { }

	public void ChangeGlassState(bool hasGlasses) { }

	public Queue GetDropsPositions(Vector3 direction, Queue freeDrops) { }

	public Queue GetDropsPositionsBleeding(Vector3 direction, Queue freeDrops, bool isArterial) { }

	private float GetRandomValue(Vector2 startDistribution, Vector2 endDistribution, float percent, bool signed = true) { }

	private Vector2 GetViewportIntersectionPoint(Vector3 direction, out float hypotenuse) { }

	public void Setup(Vector2 startScaleDimension, Vector2 endScaleDimension, Vector2 dropCountRange, Vector2 maxRayLength, Vector2 startXdistribution, Vector2 startYdistribution, Vector2 endXdistribution, Vector2 endYdistribution, float offGlassScaleMultiplier) { }

}

