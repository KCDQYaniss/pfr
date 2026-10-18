namespace EFT.UI;

[RequireComponent(typeof(BattleUIComponentAnimation))]
public sealed class CharacterHealthPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8
		public static Func <>9__22_1; //Field offset: 0x10
		public static Action <>9__22_0; //Field offset: 0x18
		public static Func <>9__26_0; //Field offset: 0x20
		public static Func <>9__28_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <get_AnyCriticalEffects>b__19_0(IHealthEffect effect) { }

		internal bool <GetEffects>b__28_0(IHealthEffect effect) { }

		internal void <Show>b__22_0(MergedEffectIconData data, StackedEffectIcon icon) { }

		internal bool <Show>b__22_1(EffectDescription e) { }

		internal IEnumerable <UpdateActiveEffects>b__26_0(IHealthEffect x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public EffectDescription effectDescription; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <UpdateActiveEffects>b__1(EffectDescription b) { }

	}

	private sealed class MergedEffectIconData
	{
		public EffectDescription Description; //Field offset: 0x10
		public int StackCount; //Field offset: 0x18

		public MergedEffectIconData() { }

	}

	[SerializeField]
	private Image _background; //Field offset: 0x70
	[SerializeField]
	private BodyPartImage _headImage; //Field offset: 0x78
	[SerializeField]
	private BodyPartImage _chestImage; //Field offset: 0x80
	[SerializeField]
	private BodyPartImage _stomachImage; //Field offset: 0x88
	[SerializeField]
	private BodyPartImage _leftHandImage; //Field offset: 0x90
	[SerializeField]
	private BodyPartImage _rightHandImage; //Field offset: 0x98
	[SerializeField]
	private BodyPartImage _leftLegImage; //Field offset: 0xA0
	[SerializeField]
	private BodyPartImage _rightLegImage; //Field offset: 0xA8
	[SerializeField]
	private GameObject _effectsPanel; //Field offset: 0xB0
	[SerializeField]
	private StackedEffectIcon _effectIconTemplate; //Field offset: 0xB8
	private BattleUIComponentAnimation _animation; //Field offset: 0xC0
	private IHealthController _healthController; //Field offset: 0xC8
	private BindableList _bindableEffects; //Field offset: 0xD0
	private bool _updateRequired; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <AutoHide>k__BackingField; //Field offset: 0xD9

	public bool AnyCriticalEffects
	{
		 get { } //Length: 370
	}

	public private bool AutoHide
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CharacterHealthPanel() { }

	public void AnimatedHide(float delaySeconds = 0) { }

	public void AnimatedShow(bool autohide) { }

	private void CleanUp() { }

	public bool get_AnyCriticalEffects() { }

	[CompilerGenerated]
	public bool get_AutoHide() { }

	private IEnumerable GetEffects() { }

	private void HealthEffectRemovedHandler(IHealthEffect effect) { }

	private void HealthEffectResiduedHandler(IHealthEffect effect) { }

	private void HealthEffectStartedHandler(IHealthEffect effect) { }

	private void HealthEffectUpdatedHandler(IHealthEffect effect) { }

	private static void MergeEffectDescriptionBuffs(EffectDescription target, EffectDescription source) { }

	[CompilerGenerated]
	private void set_AutoHide(bool value) { }

	public void Show(IHealthController healthController) { }

	private void StimulatorBuffEventHandler(IStimulatorBuff buff) { }

	private void Update() { }

	private void UpdateActiveEffects() { }

}

