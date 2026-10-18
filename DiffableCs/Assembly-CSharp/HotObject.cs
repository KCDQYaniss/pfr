//Type is in global namespace

[DefaultExecutionOrder(100)]
[RequireComponent(typeof(Renderer))]
public class HotObject : MonoBehaviour
{
	private static readonly int _HeatSizeId; //Field offset: 0x0
	private const float MinHeatParticleCount = 4; //Field offset: 0x0
	private const float HeatHazeCullDistance = 5; //Field offset: 0x0
	private const float HeatHazeVelocityFactor = 0.5; //Field offset: 0x0
	private static readonly int _HeatTempId; //Field offset: 0x4
	private static readonly int _HeatCenterId; //Field offset: 0x8
	private static readonly int _temperatureId; //Field offset: 0xC
	private static readonly int _temperatureId2; //Field offset: 0x10
	private static readonly int _HeatVisibleFactorId; //Field offset: 0x14
	private static readonly int _HeatThermalFactorId; //Field offset: 0x18
	private static readonly int _HeatVisibleId; //Field offset: 0x1C
	private static readonly string USEHEAT; //Field offset: 0x20
	[Header("Выставляет температуру конкретному объекту")]
	[SerializeField]
	[Tooltip("Применить ко всем материалам на Renderer")]
	public bool IsApplyAllMaterials; //Field offset: 0x20
	[SerializeField]
	[Tooltip("(min, max, factor)")]
	public Vector3 Temperature; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Множитель Temperature.z для управления температуры из скрипта")]
	public float TemperatureCelsio; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Порядковый номер материала в Renderer к которым необходимо применить температуру")]
	private List materialsId; //Field offset: 0x38
	[SerializeField]
	public Bounds HeatBounds; //Field offset: 0x40
	[SerializeField]
	public float VisibleHeatAlpha; //Field offset: 0x58
	[Header("Эффект HeatHaze")]
	[SerializeField]
	[Space]
	public bool UseHeatHaze; //Field offset: 0x5C
	[SerializeField]
	public Bounds HeatHazeBounds; //Field offset: 0x60
	[SerializeField]
	private Vector2 HeatParticleLifetimeDelta; //Field offset: 0x78
	[SerializeField]
	private AnimationCurve HeatParticleCountByTemp; //Field offset: 0x80
	[SerializeField]
	private AnimationCurve HeatParticleLifeTimeByTemp; //Field offset: 0x88
	[SerializeField]
	private AnimationCurve HeatParticleSizeByTemp; //Field offset: 0x90
	private MaterialPropertyBlock _materialPropertyBlock; //Field offset: 0x98
	private Renderer _renderer; //Field offset: 0xA0
	private Vector3 _prevPos; //Field offset: 0xA8
	private int _prevPosAgo; //Field offset: 0xB4
	private float _lastEmitTime; //Field offset: 0xB8
	private int _materialsCount; //Field offset: 0xBC
	private Transform _objectTransform; //Field offset: 0xC0
	private float _currentHeat; //Field offset: 0xC8
	private float _currentHeatParticleCount; //Field offset: 0xCC
	private float _currentHeatParticleLifetime; //Field offset: 0xD0
	private float _currentHeatParticleStartSize; //Field offset: 0xD4
	private bool _isInited; //Field offset: 0xD8

	private float HeatThermalFactor
	{
		private get { } //Length: 90
	}

	private float HeatVisibleFactor
	{
		private get { } //Length: 87
	}

	private static HotObject() { }

	public HotObject() { }

	private void Awake() { }

	private float ConvertCelsioHeatHaze(float celcio) { }

	private float ConvertCelsioTemp(float celcio) { }

	public static float ConvertHeat2Celsio(float heatTemp) { }

	[ContextMenu("SetTemperatureToRenderer")]
	public void DebugSetTemperatureToRenderer() { }

	private float get_HeatThermalFactor() { }

	private float get_HeatVisibleFactor() { }

	public void ManualSyncEffects() { }

	public static bool NeedProcessEffects(Vector3 camPos, Vector3 pos) { }

	public void PrepareForEffects() { }

	public void SetTemperatureToRenderer() { }

	public void SetTemperatureToRenderer(float temperatureCelsio, bool force = false) { }

	public void SyncPosition() { }

	private void TryInit() { }

}

