namespace DG.Tweening;

[Extension]
public static class TweenSettingsExtensions
{

	[Extension]
	public static Sequence Append(Sequence s, Tween t) { }

	[Extension]
	public static Sequence AppendCallback(Sequence s, TweenCallback callback) { }

	[Extension]
	public static Sequence AppendInterval(Sequence s, float interval) { }

	[Extension]
	public static TweenerCore From(TweenerCore t, float fromValue, bool setImmediately = true) { }

	[Extension]
	public static TweenerCore From(TweenerCore t, float fromAlphaValue, bool setImmediately = true) { }

	[Extension]
	public static TweenerCore From(TweenerCore t, T2 fromValue, bool setImmediately = true) { }

	[Extension]
	public static T From(T t, bool isRelative) { }

	[Extension]
	public static T From(T t) { }

	[Extension]
	public static Sequence Insert(Sequence s, float atPosition, Tween t) { }

	[Extension]
	public static Sequence InsertCallback(Sequence s, float atPosition, TweenCallback callback) { }

	[Extension]
	public static Sequence Join(Sequence s, Tween t) { }

	[Extension]
	public static T OnComplete(T t, TweenCallback action) { }

	[Extension]
	public static T OnKill(T t, TweenCallback action) { }

	[Extension]
	public static T OnPause(T t, TweenCallback action) { }

	[Extension]
	public static T OnPlay(T t, TweenCallback action) { }

	[Extension]
	public static T OnRewind(T t, TweenCallback action) { }

	[Extension]
	public static T OnStart(T t, TweenCallback action) { }

	[Extension]
	public static T OnStepComplete(T t, TweenCallback action) { }

	[Extension]
	public static T OnUpdate(T t, TweenCallback action) { }

	[Extension]
	public static T OnWaypointChange(T t, TweenCallback action) { }

	[Extension]
	public static Sequence Prepend(Sequence s, Tween t) { }

	[Extension]
	public static Sequence PrependCallback(Sequence s, TweenCallback callback) { }

	[Extension]
	public static Sequence PrependInterval(Sequence s, float interval) { }

	[Extension]
	public static T SetAs(T t, Tween asTween) { }

	[Extension]
	public static T SetAs(T t, TweenParams tweenParams) { }

	[Extension]
	public static T SetAutoKill(T t) { }

	[Extension]
	public static T SetAutoKill(T t, bool autoKillOnCompletion) { }

	[Extension]
	public static T SetDelay(T t, float delay) { }

	[Extension]
	public static T SetEase(T t, EaseFunction customEase) { }

	[Extension]
	public static T SetEase(T t, AnimationCurve animCurve) { }

	[Extension]
	public static T SetEase(T t, Ease ease, float amplitude, float period) { }

	[Extension]
	public static T SetEase(T t, Ease ease, float overshoot) { }

	[Extension]
	public static T SetEase(T t, Ease ease) { }

	[Extension]
	public static T SetId(T t, object objectId) { }

	[Extension]
	public static T SetId(T t, string stringId) { }

	[Extension]
	public static T SetId(T t, int intId) { }

	[Extension]
	public static T SetLink(T t, GameObject gameObject) { }

	[Extension]
	public static T SetLink(T t, GameObject gameObject, LinkBehaviour behaviour) { }

	[Extension]
	public static TweenerCore SetLookAt(TweenerCore t, Vector3 lookAtPosition, Nullable forwardDirection = null, Nullable up = null) { }

	[Extension]
	public static TweenerCore SetLookAt(TweenerCore t, float lookAhead, Nullable forwardDirection = null, Nullable up = null) { }

	[Extension]
	public static TweenerCore SetLookAt(TweenerCore t, Transform lookAtTransform, Nullable forwardDirection = null, Nullable up = null) { }

	[Extension]
	public static T SetLoops(T t, int loops) { }

	[Extension]
	public static T SetLoops(T t, int loops, LoopType loopType) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool useShortest360Route = true) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool alphaOnly) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool richTextEnabled, ScrambleMode scrambleMode = 0, string scrambleChars = null) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Extension]
	public static TweenerCore SetOptions(TweenerCore t, AxisConstraint lockPosition, AxisConstraint lockRotation = 0) { }

	[Extension]
	public static TweenerCore SetOptions(TweenerCore t, bool closePath, AxisConstraint lockPosition = 0, AxisConstraint lockRotation = 0) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	public static Tweener SetOptions(TweenerCore t, bool snapping) { }

	[Extension]
	private static void SetPathForwardDirection(TweenerCore t, Nullable forwardDirection = null, Nullable up = null) { }

	[Extension]
	public static T SetRecyclable(T t) { }

	[Extension]
	public static T SetRecyclable(T t, bool recyclable) { }

	[Extension]
	public static T SetRelative(T t, bool isRelative) { }

	[Extension]
	public static T SetRelative(T t) { }

	[Extension]
	public static T SetSpeedBased(T t) { }

	[Extension]
	public static T SetSpeedBased(T t, bool isSpeedBased) { }

	[Extension]
	public static T SetTarget(T t, object target) { }

	[Extension]
	public static T SetUpdate(T t, UpdateType updateType, bool isIndependentUpdate) { }

	[Extension]
	public static T SetUpdate(T t, bool isIndependentUpdate) { }

	[Extension]
	public static T SetUpdate(T t, UpdateType updateType) { }

}

