namespace UnityEngine.UIElements;

internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
{
	private struct AnimationDataSet`2
	{
		public VisualElement[] elements; //Field offset: 0x0
		public StylePropertyId[] properties; //Field offset: 0x0
		public TTimingData[] timing; //Field offset: 0x0
		public TStyleData[] style; //Field offset: 0x0
		public int count; //Field offset: 0x0
		private Dictionary indices; //Field offset: 0x0

		private int capacity
		{
			private get { } //Length: 25
			private set { } //Length: 209
		}

		public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

		public static AnimationDataSet Create() { }

		private int get_capacity() { }

		public void GetActivePropertiesForElement(VisualElement ve, List outProperties) { }

		public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }

		private void LocalInit() { }

		public void Remove(int cancelledIndex) { }

		public void RemoveAll(VisualElement ve) { }

		public void RemoveAll() { }

		public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

		private void set_capacity(int value) { }

	}

	private struct ElementPropertyPair
	{
		private class EqualityComparer : IEqualityComparer
		{

			public EqualityComparer() { }

			public override bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

			public override int GetHashCode(ElementPropertyPair obj) { }

		}

		public static readonly IEqualityComparer Comparer; //Field offset: 0x0
		public readonly VisualElement element; //Field offset: 0x0
		public readonly StylePropertyId property; //Field offset: 0x8

		private static ElementPropertyPair() { }

		public ElementPropertyPair(VisualElement element, StylePropertyId property) { }

	}

	[Flags]
	private enum TransitionState
	{
		None = 0,
		Running = 1,
		Started = 2,
		Ended = 4,
		Canceled = 8,
	}

	private abstract class Values
	{

		protected Values() { }

		public abstract void CancelAllAnimations() { }

		public abstract void CancelAllAnimations(VisualElement ve) { }

		public abstract void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		public abstract void GetAllAnimations(VisualElement ve, List outPropertyIds) { }

		public abstract void Update(long currentTimeMs) { }

		public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		protected abstract void UpdateComputedStyle() { }

		protected abstract void UpdateComputedStyle(int i) { }

		protected abstract void UpdateValues() { }

	}

	private abstract class Values`1 : Values
	{
		internal struct EmptyData
		{
			public static EmptyData Default; //Field offset: 0x0

			private static EmptyData() { }

		}

		internal struct StyleData
		{
			public T startValue; //Field offset: 0x0
			public T endValue; //Field offset: 0x0
			public T reversingAdjustedStartValue; //Field offset: 0x0
			public T currentValue; //Field offset: 0x0

		}

		internal struct TimingData
		{
			public long startTimeMs; //Field offset: 0x0
			public int durationMs; //Field offset: 0x0
			public Func easingCurve; //Field offset: 0x0
			public float easedProgress; //Field offset: 0x0
			public float reversingShorteningFactor; //Field offset: 0x0
			public bool isStarted; //Field offset: 0x0
			public int delayMs; //Field offset: 0x0

		}

		private class TransitionEventsFrameState
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal Queue <.cctor>b__11_0() { }

			}

			private static readonly ObjectPool k_EventQueuePool; //Field offset: 0x0
			public readonly Dictionary elementPropertyStateDelta; //Field offset: 0x0
			public readonly Dictionary elementPropertyQueuedEvents; //Field offset: 0x0
			public IPanel panel; //Field offset: 0x0
			private int m_ChangesCount; //Field offset: 0x0

			private static TransitionEventsFrameState() { }

			public TransitionEventsFrameState() { }

			public void Clear() { }

			public static Queue GetPooledQueue() { }

			public void RegisterChange() { }

			public bool StateChanged() { }

			public void UnregisterChange() { }

		}

		private long m_CurrentTimeMs; //Field offset: 0x0
		private TransitionEventsFrameState m_CurrentFrameEventsState; //Field offset: 0x0
		private TransitionEventsFrameState m_NextFrameEventsState; //Field offset: 0x0
		public AnimationDataSet running; //Field offset: 0x0
		public AnimationDataSet completed; //Field offset: 0x0

		public bool isEmpty
		{
			 get { } //Length: 10
		}

		public abstract Func SameFunc
		{
			 get { } //Length: 0
		}

		protected Values`1() { }

		public virtual void CancelAllAnimations() { }

		public virtual void CancelAllAnimations(VisualElement ve) { }

		public virtual void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		private void ClearEventQueue(ElementPropertyPair epp) { }

		private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

		private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

		private float ComputeReversingShorteningFactor(int oldIndex) { }

		protected override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }

		private void ForceComputedStyleEndValue(int runningIndex) { }

		public bool get_isEmpty() { }

		public abstract Func get_SameFunc() { }

		public virtual void GetAllAnimations(VisualElement ve, List outPropertyIds) { }

		private void ProcessEventQueue() { }

		private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

		private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

		private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

		private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

		private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func easingCurve, long currentTimeMs) { }

		private void SwapFrameStates() { }

		public virtual void Update(long currentTimeMs) { }

		public virtual void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		private void UpdateProgress(long currentTimeMs) { }

	}

	private class ValuesBackground : ValuesDiscrete
	{

		public ValuesBackground() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundPosition : ValuesDiscrete
	{

		public ValuesBackgroundPosition() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundRepeat : ValuesDiscrete
	{

		public ValuesBackgroundRepeat() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundSize : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesBackgroundSize() { }

		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

		private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesColor : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesColor() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(Color c, Color d) { }

		private static Color Lerp(Color a, Color b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private abstract class ValuesDiscrete`1 : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x0

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		protected ValuesDiscrete`1() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(T a, T b) { }

		private static T Lerp(T a, T b, float t) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesFloat : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesFloat() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(float a, float b) { }

		private static float Lerp(float a, float b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesFont : ValuesDiscrete
	{

		public ValuesFont() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesFontDefinition : ValuesDiscrete
	{

		public ValuesFontDefinition() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesInt : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesInt() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(int a, int b) { }

		private static int Lerp(int a, int b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesLength : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesLength() { }

		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(Length a, Length b) { }

		internal static Length Lerp(Length a, Length b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesRotate : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesRotate() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(Rotate a, Rotate b) { }

		private static Rotate Lerp(Rotate a, Rotate b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesScale : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesScale() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(Scale a, Scale b) { }

		private static Scale Lerp(Scale a, Scale b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesTextShadow : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesTextShadow() { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(TextShadow a, TextShadow b) { }

		private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesTransformOrigin : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesTransformOrigin() { }

		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

		private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private class ValuesTranslate : Values
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func SameFunc
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ValuesTranslate() { }

		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

		[CompilerGenerated]
		public virtual Func get_SameFunc() { }

		private static bool IsSame(Translate a, Translate b) { }

		private static Translate Lerp(Translate a, Translate b, float t) { }

		protected virtual void UpdateComputedStyle() { }

		protected virtual void UpdateComputedStyle(int i) { }

		protected virtual void UpdateValues() { }

	}

	private long m_CurrentTimeMs; //Field offset: 0x10
	private ValuesFloat m_Floats; //Field offset: 0x18
	private ValuesInt m_Ints; //Field offset: 0x20
	private ValuesLength m_Lengths; //Field offset: 0x28
	private ValuesColor m_Colors; //Field offset: 0x30
	private ValuesBackground m_Backgrounds; //Field offset: 0x38
	private ValuesFontDefinition m_FontDefinitions; //Field offset: 0x40
	private ValuesFont m_Fonts; //Field offset: 0x48
	private ValuesTextShadow m_TextShadows; //Field offset: 0x50
	private ValuesScale m_Scale; //Field offset: 0x58
	private ValuesRotate m_Rotate; //Field offset: 0x60
	private ValuesTranslate m_Translate; //Field offset: 0x68
	private ValuesTransformOrigin m_TransformOrigin; //Field offset: 0x70
	private ValuesBackgroundPosition m_BackgroundPosition; //Field offset: 0x78
	private ValuesBackgroundRepeat m_BackgroundRepeat; //Field offset: 0x80
	private ValuesBackgroundSize m_BackgroundSize; //Field offset: 0x88
	private readonly List m_AllValues; //Field offset: 0x90
	private readonly Dictionary m_PropertyToValues; //Field offset: 0x98

	public StylePropertyAnimationSystem() { }

	public override void CancelAllAnimations(VisualElement owner) { }

	public override void CancelAllAnimations() { }

	public override void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	private long CurrentTimeMs() { }

	public override void GetAllAnimations(VisualElement owner, List propertyIds) { }

	private T GetOrCreate(ref T values) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func easingCurve) { }

	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func easingCurve, Values values) { }

	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func easingCurve) { }

	public override void Update() { }

	public override void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	private void UpdateTracking(Values values) { }

}

