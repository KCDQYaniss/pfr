namespace EFT.Visual;

[ExecuteInEditMode]
public class Flicker : MonoBehaviour, IComponent
{
	internal enum ECurveType
	{
		SelectTypeForGenerate = 0,
		Random = 1,
		Sin = 2,
		Triangle = 3,
		Saw = 4,
		Square = 5,
	}

	[SerializeField]
	protected float Frequency; //Field offset: 0x20
	[SerializeField]
	protected float Intensity; //Field offset: 0x24
	[SerializeField]
	protected float IntensityShift; //Field offset: 0x28
	[SerializeField]
	protected float TimeShift; //Field offset: 0x2C
	[SerializeField]
	protected AnimationCurve Curve; //Field offset: 0x30
	[SerializeField]
	protected ECurveType Generate; //Field offset: 0x38
	[SerializeField]
	protected bool RandomTimeShift; //Field offset: 0x3C
	[SerializeField]
	protected bool FullRandomCurve; //Field offset: 0x3D
	public float CullingCoef; //Field offset: 0x40
	protected float RandomSeed; //Field offset: 0x44

	public Flicker() { }

	protected override void Awake() { }

	public override void ManualUpdate() { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public void SetCurve(AnimationCurve curve) { }

}

