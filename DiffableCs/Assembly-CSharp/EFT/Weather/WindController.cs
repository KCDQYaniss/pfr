namespace EFT.Weather;

public class WindController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal WindParamsSet <SetWind>b__14_0(Settings settings) { }

	}

	private static readonly int _bilboardTreesWindPower; //Field offset: 0x0
	private static readonly int _windVector; //Field offset: 0x4
	private static readonly int _prevWindVector; //Field offset: 0x8
	private static readonly int _stWindVector; //Field offset: 0xC
	public ComputeShader _windShader; //Field offset: 0x20
	public WiresController Wires; //Field offset: 0x28
	public float RainWindMultiplier; //Field offset: 0x30
	public float CloudWindMultiplier; //Field offset: 0x34
	public float BilboardTreesWindMultiplier; //Field offset: 0x38
	[SerializeField]
	private Vector2 defaultWindVector; //Field offset: 0x3C
	private Vector2 prevWindVector; //Field offset: 0x44
	private WindCalculator _windCalculator; //Field offset: 0x50

	private static WindController() { }

	public WindController() { }

	private void ApplyWindToPlants(Vector2 wind) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	public void SetWind(Settings[] windSettings) { }

	public void SetWind(Vector2 wind) { }

}

