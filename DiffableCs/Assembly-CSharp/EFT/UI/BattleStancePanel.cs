namespace EFT.UI;

[RequireComponent(typeof(BattleUIComponentAnimation))]
public sealed class BattleStancePanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <ChangeStanceImage>b__28_0(BattleStance x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public BattleStancePanel <>4__this; //Field offset: 0x10
		public int current; //Field offset: 0x18
		public int to; //Field offset: 0x1C
		public bool direction; //Field offset: 0x20

		public <>c__DisplayClass29_0() { }

		internal void <LadderSetActive>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public float value; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal float <GetClosestValue>b__0(float x) { }

	}

	[SerializeField]
	private List _battleStances; //Field offset: 0x70
	[SerializeField]
	private BattleUINoiseLevel _noiseLevel; //Field offset: 0x78
	[SerializeField]
	private BattleStanceNotch _battleStanceNotchTemplate; //Field offset: 0x80
	[SerializeField]
	private BattleUiVoipPanel _voipPanel; //Field offset: 0x88
	[SerializeField]
	private BattleStanceNotch _finalNotch; //Field offset: 0x90
	[SerializeField]
	private BattleUiBipodPanel _bipodPanel; //Field offset: 0x98
	[SerializeField]
	private RectTransform _notchesPlaceholder; //Field offset: 0xA0
	[SerializeField]
	private Slider _stanceSlider; //Field offset: 0xA8
	[SerializeField]
	private Slider _speedSlider; //Field offset: 0xB0
	[SerializeField]
	private Image _sprintFillImage; //Field offset: 0xB8
	[SerializeField]
	private Image _handsFillImage; //Field offset: 0xC0
	[SerializeField]
	private Sprite _defaultFillSprite; //Field offset: 0xC8
	[SerializeField]
	private Sprite _defaultFillSpriteForHands; //Field offset: 0xD0
	[SerializeField]
	private Sprite _exhaustedFillSprite; //Field offset: 0xD8
	private BattleUIComponentAnimation _animation; //Field offset: 0xE0
	private Player _player; //Field offset: 0xE8
	private int _currentStanceIndex; //Field offset: 0xF0
	private Coroutine _ladderSetActiveCoroutine; //Field offset: 0xF8
	private float _currentStanceImageType; //Field offset: 0x100
	private readonly Dictionary _notches; //Field offset: 0x108

	public BattleStancePanel() { }

	public void AnimatedHide(float delaySeconds = 0) { }

	public void AnimatedShow(bool autohide) { }

	private void Awake() { }

	private void ChangeMaxSpeed(float stateSpeedLimit, float clampedSpeed, float maxSpeed = 1, int noise = 1) { }

	private void ChangeSpeed(float inputSpeed, float maxCharacterSpeed = 1, int noise = 1) { }

	private void ChangeStanceImage(float type, int noise) { }

	public virtual void Close() { }

	private static float GetClosestValue(IEnumerable values, float value) { }

	private void LadderSetActive(int current, int to, bool direction) { }

	private void OnSprintStateChangedEvent(bool b) { }

	private void RemoveHandlers() { }

	public void SetNoiseLevel(int index) { }

	public void Show(Player player) { }

	private void StopLadderSetActive() { }

	private void Update() { }

}

