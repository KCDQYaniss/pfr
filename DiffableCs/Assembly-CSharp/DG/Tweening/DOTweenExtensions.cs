namespace DG.Tweening;

[Extension]
public static class DOTweenExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Light target; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal float <DORange>b__0() { }

		internal void <DORange>b__1(float x) { }

	}


	public static Tween CrossFadeHoverCanvas(Tween tween, CanvasGroup idleCanvasGroup, CanvasGroup hoverCanvasGroup, bool hoverState, bool forced, float duration = 0.5) { }

	public static Tween CrossFadeHoverGraphic(Tween tween, Graphic idleGraphic, Graphic hoverGraphic, bool hoverState, bool forced, float duration = 0.5) { }

	[Extension]
	public static TweenerCore DORange(Light target, float endValue, float duration) { }

	public static Tween FadeSwitchImages(Tween target, Image currentImage, Image newImage, float duration = 0.5, float startAlpha = 0, float endAlpha = 1, bool forced = false) { }

	public static Tween PlayColorTween(Tween tween, Graphic graphic, Color targetColor, bool forced) { }

}

