namespace DG.Tweening;

public class DOTween
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public float v; //Field offset: 0x10
		public DOSetter setter; //Field offset: 0x18

		public <>c__DisplayClass54_0() { }

		internal float <To>b__0() { }

		internal void <To>b__1(float x) { }

	}

	public static readonly string Version; //Field offset: 0x0
	public static bool useSafeMode; //Field offset: 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0xC
	public static bool showUnityEditorReport; //Field offset: 0x10
	public static float timeScale; //Field offset: 0x14
	public static bool useSmoothDeltaTime; //Field offset: 0x18
	public static float maxSmoothUnscaledTime; //Field offset: 0x1C
	internal static RewindCallbackMode rewindCallbackMode; //Field offset: 0x20
	private static LogBehaviour _logBehaviour; //Field offset: 0x24
	public static Func onWillLog; //Field offset: 0x28
	public static bool drawGizmos; //Field offset: 0x30
	public static UpdateType defaultUpdateType; //Field offset: 0x34
	public static bool defaultTimeScaleIndependent; //Field offset: 0x38
	public static AutoPlay defaultAutoPlay; //Field offset: 0x3C
	public static bool defaultAutoKill; //Field offset: 0x40
	public static LoopType defaultLoopType; //Field offset: 0x44
	public static bool defaultRecyclable; //Field offset: 0x48
	public static Ease defaultEaseType; //Field offset: 0x4C
	public static float defaultEaseOvershootOrAmplitude; //Field offset: 0x50
	public static float defaultEasePeriod; //Field offset: 0x54
	public static DOTweenComponent instance; //Field offset: 0x58
	internal static int maxActiveTweenersReached; //Field offset: 0x60
	internal static int maxActiveSequencesReached; //Field offset: 0x64
	internal static readonly List GizmosDelegates; //Field offset: 0x68
	internal static bool initialized; //Field offset: 0x70
	internal static bool isQuitting; //Field offset: 0x71

	public static LogBehaviour logBehaviour
	{
		 get { } //Length: 83
		 set { } //Length: 191
	}

	private static DOTween() { }

	public DOTween() { }

	private static TweenerCore ApplyTo(DOGetter getter, DOSetter setter, T2 endValue, float duration, ABSTweenPlugin plugin = null) { }

	private static void AutoInit() { }

	public static void Clear(bool destroy = false) { }

	public static void ClearCachedTweens() { }

	public static int Complete(object targetOrId, bool withCallbacks = false) { }

	public static int CompleteAll(bool withCallbacks = false) { }

	internal static int CompleteAndReturnKilledTot() { }

	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	public static int Flip(object targetOrId) { }

	public static int FlipAll() { }

	public static LogBehaviour get_logBehaviour() { }

	public static int Goto(object targetOrId, float to, bool andPlay = false) { }

	public static int GotoAll(float to, bool andPlay = false) { }

	public static IDOTweenInit Init(Nullable recycleAllByDefault = null, Nullable useSafeMode = null, Nullable logBehaviour = null) { }

	private static IDOTweenInit Init(DOTweenSettings settings, Nullable recycleAllByDefault, Nullable useSafeMode, Nullable logBehaviour) { }

	private static void InitCheck() { }

	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false) { }

	public static int Kill(object targetOrId, bool complete = false) { }

	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	public static int KillAll(bool complete = false) { }

	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	public static int Pause(object targetOrId) { }

	public static int PauseAll() { }

	public static List PausedTweens(List fillableList = null) { }

	public static int Play(object target, object id) { }

	public static int Play(object targetOrId) { }

	public static int PlayAll() { }

	public static int PlayBackwards(object target, object id) { }

	public static int PlayBackwards(object targetOrId) { }

	public static int PlayBackwardsAll() { }

	public static int PlayForward(object target, object id) { }

	public static int PlayForward(object targetOrId) { }

	public static int PlayForwardAll() { }

	public static List PlayingTweens(List fillableList = null) { }

	public static TweenerCore Punch(DOGetter getter, DOSetter setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1) { }

	public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1) { }

	public static int RestartAll(bool includeDelay = true) { }

	public static int Rewind(object targetOrId, bool includeDelay = true) { }

	public static int RewindAll(bool includeDelay = true) { }

	public static Sequence Sequence() { }

	public static void set_logBehaviour(LogBehaviour value) { }

	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	private static TweenerCore Shake(DOGetter getter, DOSetter setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	public static TweenerCore Shake(DOGetter getter, DOSetter setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	public static TweenerCore Shake(DOGetter getter, DOSetter setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = true, bool fadeOut = true) { }

	public static int SmoothRewind(object targetOrId) { }

	public static int SmoothRewindAll() { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, ulong endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, double endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, string endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Vector2 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Vector3 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Vector4 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Vector3 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, long endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Rect endValue, float duration) { }

	public static Tweener To(DOGetter getter, DOSetter setter, RectOffset endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, Color endValue, float duration) { }

	public static Tweener To(DOSetter setter, float startValue, float endValue, float duration) { }

	internal static TweenerCore To(DOGetter getter, DOSetter setter, Color2 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, uint endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, int endValue, float duration) { }

	public static TweenerCore To(ABSTweenPlugin plugin, DOGetter getter, DOSetter setter, T2 endValue, float duration) { }

	public static TweenerCore To(DOGetter getter, DOSetter setter, float endValue, float duration) { }

	public static TweenerCore ToAlpha(DOGetter getter, DOSetter setter, float endValue, float duration) { }

	public static TweenerCore ToArray(DOGetter getter, DOSetter setter, Vector3[] endValues, float[] durations) { }

	public static TweenerCore ToAxis(DOGetter getter, DOSetter setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	public static int TogglePause(object targetOrId) { }

	public static int TogglePauseAll() { }

	public static int TotalPlayingTweens() { }

	public static List TweensById(object id, bool playingOnly = false, List fillableList = null) { }

	public static List TweensByTarget(object target, bool playingOnly = false, List fillableList = null) { }

	public static int Validate() { }

}

