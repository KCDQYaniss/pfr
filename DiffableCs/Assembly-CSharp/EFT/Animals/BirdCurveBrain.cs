namespace EFT.Animals;

[RequireComponent(typeof(Bird))]
public class BirdCurveBrain : UpdateInEditorSystemComponent
{
	[SerializeField]
	protected BezierSpline _spline; //Field offset: 0x20
	[SerializeField]
	protected float _baseSpeed; //Field offset: 0x28
	[SerializeField]
	protected float _gForceMult; //Field offset: 0x2C
	protected Vector3 _gForce; //Field offset: 0x30
	protected Bird _bird; //Field offset: 0x40
	protected float _splineLength; //Field offset: 0x48
	protected float _currentSpeed; //Field offset: 0x4C
	protected float _currentDuration; //Field offset: 0x50
	protected float _currentSplineTime; //Field offset: 0x54

	public BirdCurveBrain() { }

	protected void Awake() { }

	public void Init(BezierSpline spline) { }

	public virtual void ManualUpdate(float deltaTime) { }

	protected void RecalculateSpeed(Vector3 direction) { }

}

