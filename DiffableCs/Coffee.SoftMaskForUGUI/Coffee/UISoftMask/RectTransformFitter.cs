namespace Coffee.UISoftMask;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public sealed class RectTransformFitter : MonoBehaviour, ILayoutElement, ILayoutIgnorer
{
	[Flags]
	internal enum RectTransformProperties
	{
		PositionX = 2,
		PositionY = 4,
		PositionZ = 8,
		Position2D = 6,
		Position = 14,
		Rotation = 16,
		ScaleX = 32,
		ScaleY = 64,
		ScaleZ = 128,
		Scale = 224,
		SizeDeltaX = 4096,
		SizeDeltaY = 8192,
		SizeDelta = 12288,
	}

	[SerializeField]
	[Tooltip("Target RectTransform to fit.")]
	private RectTransform m_Target; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Target RectTransform properties.")]
	private RectTransformProperties m_TargetProperties; //Field offset: 0x28
	private Action _fit; //Field offset: 0x30
	private RectTransform _rectTransform; //Field offset: 0x38
	private DrivenRectTransformTracker _tracker; //Field offset: 0x40

	public RectTransform target
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public RectTransformProperties targetProperties
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	private override float UnityEngine.UI.ILayoutElement.flexibleHeight
	{
		private get { } //Length: 4
	}

	private override float UnityEngine.UI.ILayoutElement.flexibleWidth
	{
		private get { } //Length: 4
	}

	private override int UnityEngine.UI.ILayoutElement.layoutPriority
	{
		private get { } //Length: 3
	}

	private override float UnityEngine.UI.ILayoutElement.minHeight
	{
		private get { } //Length: 4
	}

	private override float UnityEngine.UI.ILayoutElement.minWidth
	{
		private get { } //Length: 4
	}

	private override float UnityEngine.UI.ILayoutElement.preferredHeight
	{
		private get { } //Length: 4
	}

	private override float UnityEngine.UI.ILayoutElement.preferredWidth
	{
		private get { } //Length: 4
	}

	private override bool UnityEngine.UI.ILayoutIgnorer.ignoreLayout
	{
		private get { } //Length: 3
	}

	public RectTransformFitter() { }

	private void Fit() { }

	public RectTransform get_target() { }

	public RectTransformProperties get_targetProperties() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void set_target(RectTransform value) { }

	public void set_targetProperties(RectTransformProperties value) { }

	private override void UnityEngine.UI.ILayoutElement.CalculateLayoutInputHorizontal() { }

	private override void UnityEngine.UI.ILayoutElement.CalculateLayoutInputVertical() { }

	private override float UnityEngine.UI.ILayoutElement.get_flexibleHeight() { }

	private override float UnityEngine.UI.ILayoutElement.get_flexibleWidth() { }

	private override int UnityEngine.UI.ILayoutElement.get_layoutPriority() { }

	private override float UnityEngine.UI.ILayoutElement.get_minHeight() { }

	private override float UnityEngine.UI.ILayoutElement.get_minWidth() { }

	private override float UnityEngine.UI.ILayoutElement.get_preferredHeight() { }

	private override float UnityEngine.UI.ILayoutElement.get_preferredWidth() { }

	private override bool UnityEngine.UI.ILayoutIgnorer.get_ignoreLayout() { }

}

