namespace DG.Tweening;

public abstract class Tweener : Tween
{
	internal bool hasManuallySetStartValue; //Field offset: 0x118
	internal bool isFromAllowed; //Field offset: 0x119

	internal Tweener() { }

	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	internal static TweenerCore DoChangeEndValue(TweenerCore t, T2 newEndValue, float newDuration, bool snapStartValue) { }

	internal static TweenerCore DoChangeStartValue(TweenerCore t, T2 newStartValue, float newDuration) { }

	internal static TweenerCore DoChangeValues(TweenerCore t, T2 newStartValue, T2 newEndValue, float newDuration) { }

	internal static bool DoStartup(TweenerCore t) { }

	private static void DOStartupDurationBased(TweenerCore t) { }

	private static bool DOStartupSpecials(TweenerCore t) { }

	internal static float DoUpdateDelay(TweenerCore t, float elapsed) { }

	internal abstract Tweener SetFrom(bool relative) { }

	internal static bool Setup(TweenerCore t, DOGetter getter, DOSetter setter, T2 endValue, float duration, ABSTweenPlugin plugin = null) { }

}

