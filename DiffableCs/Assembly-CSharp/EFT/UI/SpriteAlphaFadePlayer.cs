namespace EFT.UI;

public sealed class SpriteAlphaFadePlayer : SpriteAnimationPlayer, ITweenController
{
	private sealed class FloatTargetGroup`1 : IFloatTargetGroup
	{
		private const float MIN_AUTHORED_VALUE = 0.0001; //Field offset: 0x0
		private readonly Func _getTargets; //Field offset: 0x0
		private readonly Func _getValue; //Field offset: 0x0
		private readonly Action _setValue; //Field offset: 0x0
		private float[] _defaultValues; //Field offset: 0x0

		public override bool HasTargets
		{
			 get { } //Length: 70
		}

		public FloatTargetGroup`1(Func getTargets, Func getValue, Action setValue) { }

		public override void ApplyValue(float value) { }

		public override void CacheDefaults() { }

		public override bool get_HasTargets() { }

		private float ReadAuthoredValue(T target) { }

	}

	private interface IFloatTargetGroup
	{

		public bool HasTargets
		{
			 get { } //Length: 0
		}

		public void ApplyValue(float value) { }

		public void CacheDefaults() { }

		public bool get_HasTargets() { }

	}

	internal interface ITweenController
	{

		public void Run(Tween tween) { }

		public void Stop() { }

	}

	[SerializeField]
	private Image[] _images; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup[] _canvasGroups; //Field offset: 0x80
	[FormerlySerializedAs("_idleAlpha")]
	[SerializeField]
	private float _idleValue; //Field offset: 0x88
	[FormerlySerializedAs("_hoverAlpha")]
	[SerializeField]
	private float _hoverValue; //Field offset: 0x8C
	private IFloatTargetGroup[] _floatTargetGroups; //Field offset: 0x90
	private float _progress; //Field offset: 0x98
	private Tween _progressTween; //Field offset: 0xA0
	private ITweenController _activeTweenController; //Field offset: 0xA8

	public SpriteAlphaFadePlayer() { }

	[CompilerGenerated]
	private float <AnimateProgress>b__20_0() { }

	[CompilerGenerated]
	private Image[] <EnsureFloatTargetGroupsInitialized>b__18_0() { }

	[CompilerGenerated]
	private CanvasGroup[] <EnsureFloatTargetGroupsInitialized>b__18_1() { }

	private void AnimateProgress(float targetProgress, ITweenController tweenController) { }

	private void ApplyProgress(float progress) { }

	private void Awake() { }

	public virtual void Close() { }

	private override void EFT.UI.SpriteAlphaFadePlayer.ITweenController.Run(Tween tween) { }

	private override void EFT.UI.SpriteAlphaFadePlayer.ITweenController.Stop() { }

	private void EnsureFloatTargetGroupsInitialized() { }

	private void EnsureFloatTargetsCached() { }

	private float GetCanvasGroupAlpha(CanvasGroup canvasGroup) { }

	private float GetImageAlpha(Image image) { }

	private bool HasFloatTargets() { }

	private void OnAnimationCompleted() { }

	private void OnDisable() { }

	public virtual void OnMouseExit() { }

	public virtual void OnMouseOver() { }

	public void ResetPreview() { }

	private void ResetProgress() { }

	private void SetCanvasGroupAlpha(CanvasGroup canvasGroup, float alpha) { }

	private void SetImageAlpha(Image image, float alpha) { }

	public virtual void SetSprites(Sprite idleSprite, Sprite hoverSprite, Sprite[] hoverAnimationSprites = null) { }

	public void StartPreview(ITweenController tweenController) { }

	public void StopPreview(ITweenController tweenController) { }

}

