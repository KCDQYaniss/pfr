namespace Coffee.UISoftMask;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
public class TerminalMaskingShape : MaskableGraphic, ILayoutElement, ILayoutIgnorer, IMaskable
{
	private static Material s_SharedTerminalMaterial; //Field offset: 0x0
	private Mask _mask; //Field offset: 0xE0
	private Mask _parentMask; //Field offset: 0xE8
	private bool _shouldRecalculateStencil; //Field offset: 0xF0
	private int _stencilBits; //Field offset: 0xF4

	public virtual bool raycastTarget
	{
		 get { } //Length: 3
		 set { } //Length: 3
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

	public TerminalMaskingShape() { }

	public virtual bool get_raycastTarget() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	private void RecalculateStencilIfNeeded() { }

	public virtual void set_raycastTarget(bool value) { }

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

	private override void UnityEngine.UI.IMaskable.RecalculateMasking() { }

}

