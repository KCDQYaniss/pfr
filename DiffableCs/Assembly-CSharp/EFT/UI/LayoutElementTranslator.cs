namespace EFT.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public sealed class LayoutElementTranslator : UIBehaviour, ILayoutElement
{
	public Component Source; //Field offset: 0x20
	private Object _cachedSource; //Field offset: 0x28
	private ILayoutElement _cachedLayout; //Field offset: 0x30

	public override float flexibleHeight
	{
		 get { } //Length: 111
	}

	public override float flexibleWidth
	{
		 get { } //Length: 111
	}

	private bool IsLayoutElement
	{
		private get { } //Length: 22
	}

	private bool IsNotLayoutElement
	{
		private get { } //Length: 22
	}

	private ILayoutElement Layout
	{
		private get { } //Length: 298
	}

	public override int layoutPriority
	{
		 get { } //Length: 108
	}

	public override float minHeight
	{
		 get { } //Length: 111
	}

	public override float minWidth
	{
		 get { } //Length: 111
	}

	public override float preferredHeight
	{
		 get { } //Length: 111
	}

	public override float preferredWidth
	{
		 get { } //Length: 111
	}

	public LayoutElementTranslator() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	private bool get_IsLayoutElement() { }

	private bool get_IsNotLayoutElement() { }

	private ILayoutElement get_Layout() { }

	public override int get_layoutPriority() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	protected virtual void OnBeforeTransformParentChanged() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	private void SetDirty() { }

}

