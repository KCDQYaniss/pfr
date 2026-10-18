namespace EFT.GameTriggers;

public class HandlerEffect : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__28 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerEffect <>4__this; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_InputTriggerIds>d__28(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__30 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_OutputTriggerIds>d__30(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct AddStaminaZeroEffectApplier : IEffectApplier
	{
		[SerializeField]
		private float _applyTime; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct ChronicStaminaFatigueApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct ContusionApplier : IEffectApplier
	{
		[SerializeField]
		private float _applyTime; //Field offset: 0x0
		[SerializeField]
		private float _applyStrength; //Field offset: 0x4

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct DisorientationApplier : IEffectApplier
	{
		[SerializeField]
		private float _applyTime; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct DoWoundApplier : IEffectApplier
	{
		[SerializeField]
		private float _value; //Field offset: 0x0
		[SerializeField]
		private EBodyPart _bodyPart; //Field offset: 0x4

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct EffectsSet
	{
		[CompilerGenerated]
		private sealed class <get_Effects>d__21 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private IEffectApplier <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public EffectsSet <>4__this; //Field offset: 0x28
			public EffectsSet <>3__<>4__this; //Field offset: 0xC8
			private RemoveAllEffects[] <>7__wrap1; //Field offset: 0x168
			private int <>7__wrap2; //Field offset: 0x170
			private DoWoundApplier[] <>7__wrap3; //Field offset: 0x178
			private AddStaminaZeroEffectApplier[] <>7__wrap4; //Field offset: 0x180
			private SandingScreenApplier[] <>7__wrap5; //Field offset: 0x188
			private RadExposureApplier[] <>7__wrap6; //Field offset: 0x190
			private PainKillerApplier[] <>7__wrap7; //Field offset: 0x198
			private OverEncumberedApplier[] <>7__wrap8; //Field offset: 0x1A0
			private MisfireEffectHealth[] <>7__wrap9; //Field offset: 0x1A8
			private IntoxicationApplier[] <>7__wrap10; //Field offset: 0x1B0
			private ImmunityPreventedNegativeEffectApplier[] <>7__wrap11; //Field offset: 0x1B8
			private HealthBoostApplier[] <>7__wrap12; //Field offset: 0x1C0
			private RestoreFullHealthsApplier[] <>7__wrap13; //Field offset: 0x1C8
			private FractureApplier[] <>7__wrap14; //Field offset: 0x1D0
			private EnduranceApplier[] <>7__wrap15; //Field offset: 0x1D8
			private DisorientationApplier[] <>7__wrap16; //Field offset: 0x1E0
			private ContusionApplier[] <>7__wrap17; //Field offset: 0x1E8
			private ChronicStaminaFatigueApplier[] <>7__wrap18; //Field offset: 0x1F0
			private LightBleedingApplier[] <>7__wrap19; //Field offset: 0x1F8
			private HeavyBleedingApplier[] <>7__wrap20; //Field offset: 0x200
			private PanicMassFireApplier[] <>7__wrap21; //Field offset: 0x208

			private override IEffectApplier System.Collections.Generic.IEnumerator<EFT.GameTriggers.HandlerEffect.IEffectApplier>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <get_Effects>d__21(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<EFT.GameTriggers.HandlerEffect.IEffectApplier>.GetEnumerator() { }

			[DebuggerHidden]
			private override IEffectApplier System.Collections.Generic.IEnumerator<EFT.GameTriggers.HandlerEffect.IEffectApplier>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public RemoveAllEffects[] RemoveAll; //Field offset: 0x0
		public DoWoundApplier[] DoWound; //Field offset: 0x8
		public AddStaminaZeroEffectApplier[] AddStamina; //Field offset: 0x10
		public SandingScreenApplier[] Sanding; //Field offset: 0x18
		public RadExposureApplier[] RadExposure; //Field offset: 0x20
		public PainKillerApplier[] PainKiller; //Field offset: 0x28
		public OverEncumberedApplier[] OverEncumbered; //Field offset: 0x30
		public MisfireEffectHealth[] Misfire; //Field offset: 0x38
		public IntoxicationApplier[] Intoxication; //Field offset: 0x40
		public ImmunityPreventedNegativeEffectApplier[] ImmunityPrevented; //Field offset: 0x48
		public HealthBoostApplier[] HealthBoost; //Field offset: 0x50
		public RestoreFullHealthsApplier[] RestoreFullHealths; //Field offset: 0x58
		public FractureApplier[] Fracture; //Field offset: 0x60
		public EnduranceApplier[] Endurance; //Field offset: 0x68
		public DisorientationApplier[] Disorientation; //Field offset: 0x70
		public ContusionApplier[] Contusion; //Field offset: 0x78
		public ChronicStaminaFatigueApplier[] ChronicStamina; //Field offset: 0x80
		public LightBleedingApplier[] LightBleeding; //Field offset: 0x88
		public HeavyBleedingApplier[] HeavyBleeding; //Field offset: 0x90
		public PanicMassFireApplier[] PanicMassFire; //Field offset: 0x98

		public IEnumerable Effects
		{
			[IteratorStateMachine(typeof(<get_Effects>d__21))]
			 get { } //Length: 375
		}

		[IteratorStateMachine(typeof(<get_Effects>d__21))]
		public IEnumerable get_Effects() { }

	}

	internal struct EnduranceApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct FractureApplier : IEffectApplier
	{
		[SerializeField]
		private EBodyPart _bodyPart; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct HealthBoostApplier : IEffectApplier
	{
		[SerializeField]
		private float _bodyPartHpPerSecond; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct HeavyBleedingApplier : IEffectApplier
	{
		[SerializeField]
		private EBodyPart _bodyPart; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal interface IEffectApplier
	{

		public void Apply(ActiveHealthController healthController) { }

	}

	internal struct ImmunityPreventedNegativeEffectApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct IntoxicationApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct LightBleedingApplier : IEffectApplier
	{
		[SerializeField]
		private EBodyPart _bodyPart; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct MisfireEffectHealth : IEffectApplier
	{
		[SerializeField]
		private float _workTime; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct OverEncumberedApplier : IEffectApplier
	{
		[SerializeField]
		private bool _state; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct PainKillerApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct PanicMassFireApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct RadExposureApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct RemoveAllEffects : IEffectApplier
	{
		[SerializeField]
		private EBodyPart[] _bodyParts; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct RestoreFullHealthsApplier : IEffectApplier
	{
		[SerializeField]
		private bool _; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	internal struct SandingScreenApplier : IEffectApplier
	{
		[SerializeField]
		private float _applyTime; //Field offset: 0x0

		public override void Apply(ActiveHealthController healthController) { }

	}

	[Range(0, 1)]
	[SerializeField]
	private float _chance; //Field offset: 0x20
	[SerializeField]
	private string _triggerId; //Field offset: 0x28
	[SerializeField]
	private EffectsSet _effects; //Field offset: 0x30

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__28))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__30))]
		 get { } //Length: 80
	}

	public HandlerEffect() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__28))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__30))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void HandleEvent(TriggerEvent triggerEvent) { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

