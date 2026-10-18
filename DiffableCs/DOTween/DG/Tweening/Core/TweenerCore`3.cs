namespace DG.Tweening.Core;

public class TweenerCore`3 : Tweener
{
	private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; //Field offset: 0x0
	public T2 startValue; //Field offset: 0x0
	public T2 endValue; //Field offset: 0x0
	public T2 changeValue; //Field offset: 0x0
	public TPlugOptions plugOptions; //Field offset: 0x0
	public DOGetter getter; //Field offset: 0x0
	public DOSetter setter; //Field offset: 0x0
	internal ABSTweenPlugin tweenPlugin; //Field offset: 0x0

	internal TweenerCore`3() { }

	internal virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	public virtual Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	public virtual Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	public TweenerCore ChangeEndValue(T2 newEndValue, bool snapStartValue) { }

	public TweenerCore ChangeEndValue(T2 newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	public virtual Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	public TweenerCore ChangeStartValue(T2 newStartValue, float newDuration = -1) { }

	public virtual Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	public TweenerCore ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1) { }

	internal virtual void Reset() { }

	internal virtual Tweener SetFrom(bool relative) { }

	internal Tweener SetFrom(T2 fromValue, bool setImmediately) { }

	internal virtual bool Startup() { }

	internal virtual float UpdateDelay(float elapsed) { }

	internal virtual bool Validate() { }

}

