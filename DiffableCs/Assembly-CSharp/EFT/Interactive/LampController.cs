namespace EFT.Interactive;

public sealed class LampController : Turnable, ILightSwitcher, IComponent
{
	public const float MIN_SWITCH_TIME = 0.1; //Field offset: 0x0
	private static int _updateCounter; //Field offset: 0x0
	[Header("Lists")]
	[Tooltip("Перечень источников освещения, имеющих Light-компонент")]
	public Light[] Lights; //Field offset: 0x38
	[Tooltip("Перечень источников освещения, имеющих Light Area компонент. Внутри строчки аналогичны Lights")]
	public BaseLight[] AreaAndTubeLights; //Field offset: 0x40
	[Tooltip("Не используется")]
	public AdvancedLight[] CustomLights; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Перечень источников освещения, имеющих Multi Flare Light компонент. Внутри строчки аналогичны Lights")]
	public FlareLight[] MultiFlareLights; //Field offset: 0x50
	[FormerlySerializedAs("_materialEmissions")]
	[SerializeField]
	[Tooltip("Ссылки на гейм-объекты, в которых указаны материалы с новыми шейдерами")]
	public MaterialEmission[] _materialsWithEmission; //Field offset: 0x58
	[FormerlySerializedAs("Materials")]
	[SerializeField]
	[Tooltip("Ссылки на гейм-объекты, в которых указаны материалы с новыми шейдерами (устаревший вариант)")]
	public MaterialColor[] _legacyMaterialsWithEmission; //Field offset: 0x60
	[SerializeField]
	[Tooltip("Список гейм-объектов с геометрией включенного состояния источника овещения")]
	public GameObject[] OnObjects; //Field offset: 0x68
	[SerializeField]
	[Tooltip("Всегда повторяет объекты On Objects, должен быть заполнен у компонентов с активированным Working interval")]
	public GameObject[] OffObjects; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Список гейм-объектов с геометрией разбитого состояния источника овещения")]
	public GameObject[] DestroyedObjects; //Field offset: 0x78
	[Header("Working Interval (hours)")]
	[Tooltip("Если установлено - источник будет работать ночью и выключаться днем")]
	public bool isTimeOfDayDependant; //Field offset: 0x80
	[Tooltip("Если установлено - источник будет работать в указанном временном диапазоне")]
	public bool isCertainInterval; //Field offset: 0x81
	[FormerlySerializedAs("MinMaxAmount1")]
	[MinMaxVec2Int(0, 12)]
	[Tooltip("Показывает время работы с 0 до 12 часов в игровом времени. Числа показывают диапазон часов, когда состояние источника будет On")]
	public Vector2Int Am; //Field offset: 0x84
	[FormerlySerializedAs("MinMaxAmount2")]
	[MinMaxVec2Int(12, 24)]
	[Tooltip("Аналогично Min Max Amount 1 для времени работы с 12 до 24 часов в игровом времени")]
	public Vector2Int Pm; //Field offset: 0x8C
	[Header("Audio")]
	[SerializeField]
	[Tooltip("Ссылка на компонент звука (добавляется в гейм-объект после Lamp Controller)")]
	public AudioSource AudioSource; //Field offset: 0x98
	[Tooltip("Резкость появления звука источника.")]
	public int Rolloff; //Field offset: 0xA0
	[SerializeField]
	[Tooltip("Одиночный звук выключения лампы, при переходе в стейт Off")]
	public AudioClip TurnOffClip; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("Одиночный звук включения лампы при переходе в стейт On")]
	public AudioClip TurnedOnClipStart; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("Зацикленный звук работы лампы, включается при переходе в стейт On")]
	public AudioClip TurnedOnClipLoop; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("Зацикленный звук работы лампы. Работает в состоянии ConstantFlickering")]
	public AudioClip FlickeringClipLoop; //Field offset: 0xC0
	[SerializeField]
	[Tooltip("Диапазон случайных значений тональности, при каждом воспроизведении, стандартное значение - 0.05, максимальное - 0.3")]
	public float PitchRandom; //Field offset: 0xC8
	[SerializeField]
	[Tooltip("Случайный звук из списка, проигрываемый во включенном состоянии")]
	public AudioClip[] TurnOnClips; //Field offset: 0xD0
	[SerializeField]
	[Tooltip("Порог максимальной интенсивности лампы, при которой будут воспроизводиться звуки щелчков")]
	public float FlickHighTreshold; //Field offset: 0xD8
	[SerializeField]
	[Tooltip("Порог минимальной интенсивности лампы, при которой будут воспроизводиться звуки щелчков")]
	public float FlickLowTreshold; //Field offset: 0xDC
	[SerializeField]
	[Tooltip("Диапазон громкости от минимальной до максимальной, по X выставляется мин. значение, по Y - макс")]
	public Vector2 FlickVolume; //Field offset: 0xE0
	[Header("Blinking")]
	[SerializeField]
	public AnimationCurve _animationCurve; //Field offset: 0xE8
	[SerializeField]
	public bool _useCurve; //Field offset: 0xF0
	[SerializeField]
	public float FlickeringFreq; //Field offset: 0xF4
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public Vector2 TurnedOnLengthMinMax; //Field offset: 0xF8
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public Vector2 TurnedOffLengthMinMax; //Field offset: 0x100
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public float FadeInPower; //Field offset: 0x108
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public float FadeOutPower; //Field offset: 0x10C
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public float TurningOnFlickering; //Field offset: 0x110
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public float TurningOffFlickering; //Field offset: 0x114
	[HideInInspectorButNotInDebug]
	[SerializeField]
	public float TurnedOnFlickering; //Field offset: 0x118
	[Header("Damage")]
	[SerializeField]
	[Tooltip("Поле с названием эффекта искр")]
	public string SparksEffect; //Field offset: 0x120
	[HideInInspectorButNotInDebug]
	[SerializeField]
	[Tooltip("Интервал в котором будут проигрываться эффекты искр. Случайное число")]
	public Vector2 SparksFreq; //Field offset: 0x128
	[SerializeField]
	[Tooltip("Поле с названием эффекта разрушения источника")]
	public string DestroyEffect; //Field offset: 0x130
	[HideInInspectorButNotInDebug]
	[SerializeField]
	[Tooltip("Оставить по умолчанию")]
	public float IntactTime; //Field offset: 0x138
	[SerializeField]
	[Tooltip("Ссылка на гейм-объект, от позиции которого будет проигрываться эффект искр")]
	public Transform SparksEmmiterTransform; //Field offset: 0x140
	[SerializeField]
	[Tooltip("Ссылка на гейм-объект, от позиции которого будет проигрываться эффект разрушения")]
	public Transform DestroyEffectPivot; //Field offset: 0x148
	[SerializeField]
	[Tooltip("Направление распространения эффектов (на сцене выглядит, как белая стрелка)")]
	public Vector3 EffectDirection; //Field offset: 0x150
	private EState _disabledState; //Field offset: 0x15C
	private bool _enabled; //Field offset: 0x160
	private bool _instantUpdateRequired; //Field offset: 0x161
	private LampStateMachine _stateMachine; //Field offset: 0x168
	private LampSound _lampSound; //Field offset: 0x170
	private LampLights _lampLights; //Field offset: 0x178
	private CommandContainer _commandContainer; //Field offset: 0x180
	[CompilerGenerated]
	private int <UpdateIndex>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private bool <IsIntensityChangeDisabled>k__BackingField; //Field offset: 0x18C
	[CompilerGenerated]
	private Action OnLampDestroy; //Field offset: 0x190

	public event Action OnLampDestroy
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override bool Enabled
	{
		 get { } //Length: 8
		 set { } //Length: 56
	}

	public bool InstantUpdateRequired
	{
		 get { } //Length: 20
	}

	public bool IsIntensityChangeDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private int UpdateIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public LampController() { }

	[CompilerGenerated]
	public void add_OnLampDestroy(Action value) { }

	private void Awake() { }

	public override bool get_Enabled() { }

	public bool get_InstantUpdateRequired() { }

	[CompilerGenerated]
	public bool get_IsIntensityChangeDisabled() { }

	[CompilerGenerated]
	public int get_UpdateIndex() { }

	public void LogicalUpdate(float time, float deltaTime) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RaiseDestroyed() { }

	[CompilerGenerated]
	public void remove_OnLampDestroy(Action value) { }

	public override void set_Enabled(bool value) { }

	[CompilerGenerated]
	public void set_IsIntensityChangeDisabled(bool value) { }

	[CompilerGenerated]
	private void set_UpdateIndex(int value) { }

	private void Start() { }

	public virtual void Switch(EState switchTo) { }

	public void TryToBlowUp(IExplosiveItem grenade, in Vector3 grenadePosition) { }

	private bool TryToInit() { }

	public override void TurnOff() { }

	public override void TurnOn() { }

	public void VisualUpdate(float time) { }

}

