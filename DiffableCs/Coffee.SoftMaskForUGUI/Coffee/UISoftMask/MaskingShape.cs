namespace Coffee.UISoftMask;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Graphic))]
public class MaskingShape : UIBehaviour, IMeshModifier, IMaterialModifier, IComparable, IMaskable, ISoftMasking
{
	internal enum MaskingMethod
	{
		Additive = 0,
		Subtract = 1,
	}

	internal enum RaycastMethod
	{
		Auto = 0,
		Additive = 1,
		Subtract = 2,
		Ignore = 3,
	}

	[SerializeField]
	[Tooltip("Masking method.")]
	private MaskingMethod m_MaskingMethod; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Show the graphic that is associated with the Mask render area.")]
	private bool m_ShowMaskGraphic; //Field offset: 0x24
	[SerializeField]
	[Tooltip("The transparent part of the mask cannot be clicked.\nThis can be achieved by enabling Read/Write enabled in the Texture Import Settings for the texture.\n\nNOTE: Enable this only if necessary, as it will require more graphics memory and processing time.")]
	private bool m_AlphaHitTest; //Field offset: 0x25
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The threshold for anti-alias masking.\nThe smaller this value, the less jagged it is.")]
	private float m_AntiAliasingThreshold; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The minimum and maximum alpha values used for soft masking.\nThe larger the gap between these values, the stronger the softness effect.")]
	private MinMax01 m_SoftnessRange; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Method to determine whether this masking shape should be a raycast target.")]
	private RaycastMethod m_RaycastMethod; //Field offset: 0x34
	private bool _antiAliasingRegistered; //Field offset: 0x38
	private MaskingShapeContainer _container; //Field offset: 0x40
	private Graphic _graphic; //Field offset: 0x48
	private Mask _mask; //Field offset: 0x50
	private Material _maskMaterial; //Field offset: 0x58
	private Mesh _mesh; //Field offset: 0x60
	private MaterialPropertyBlock _mpb; //Field offset: 0x68
	private Matrix4x4 _prevTransformMatrix; //Field offset: 0x70
	private UnityAction _setContainerDirty; //Field offset: 0xB0
	private bool _shouldRecalculateStencil; //Field offset: 0xB8
	private int _stencilBits; //Field offset: 0xBC
	private Action _updateAntiAliasing; //Field offset: 0xC0
	private UnityAction _updateContainer; //Field offset: 0xC8
	[CompilerGenerated]
	private ISoftMasking <parent>k__BackingField; //Field offset: 0xD0

	public RaycastMethod actualRaycastMethod
	{
		 get { } //Length: 275
	}

	public override bool alphaHitTest
	{
		 get { } //Length: 91
		 set { } //Length: 4
	}

	public override float antiAliasingThreshold
	{
		 get { } //Length: 92
		 set { } //Length: 6
	}

	public Graphic graphic
	{
		 get { } //Length: 259
	}

	public bool hasTransformChanged
	{
		 get { } //Length: 165
	}

	public override MaskingMethod maskingMethod
	{
		 get { } //Length: 90
		 set { } //Length: 45
	}

	internal ISoftMasking parent
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public override RaycastMethod raycastMethod
	{
		 get { } //Length: 90
		 set { } //Length: 4
	}

	public override bool showMaskGraphic
	{
		 get { } //Length: 91
		 set { } //Length: 16
	}

	public override MinMax01 softnessRange
	{
		 get { } //Length: 220
		 set { } //Length: 88
	}

	public MaskingShape() { }

	internal bool AntiAliasingEnabled() { }

	private override bool Coffee.UISoftMask.ISoftMasking.get_enabled() { }

	internal void DrawSoftMaskBuffer(CommandBuffer cb, int depth) { }

	public RaycastMethod get_actualRaycastMethod() { }

	public override bool get_alphaHitTest() { }

	public override float get_antiAliasingThreshold() { }

	public Graphic get_graphic() { }

	public bool get_hasTransformChanged() { }

	public override MaskingMethod get_maskingMethod() { }

	[CompilerGenerated]
	internal ISoftMasking get_parent() { }

	public override RaycastMethod get_raycastMethod() { }

	public override bool get_showMaskGraphic() { }

	public override MinMax01 get_softnessRange() { }

	internal bool IsInside(Vector2 sp, Camera eventCamera, float threshold = 0.01) { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformParentChanged() { }

	private void RecalculateStencilIfNeeded() { }

	private void RegisterAntiAliasingIfNeeded() { }

	public void set_alphaHitTest(bool value) { }

	public void set_antiAliasingThreshold(float value) { }

	public void set_maskingMethod(MaskingMethod value) { }

	[CompilerGenerated]
	internal void set_parent(ISoftMasking value) { }

	public void set_raycastMethod(RaycastMethod value) { }

	public void set_showMaskGraphic(bool value) { }

	public void set_softnessRange(MinMax01 value) { }

	private void SetContainerDirty() { }

	private void SetMaterialDirty() { }

	internal bool SoftMaskEnabled() { }

	private override int System.IComparable<Coffee.UISoftMask.MaskingShape>.CompareTo(MaskingShape other) { }

	private override void UnityEngine.UI.IMaskable.RecalculateMasking() { }

	private override Material UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(Material baseMaterial) { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(Mesh mesh) { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(VertexHelper verts) { }

	private void UpdateAntiAliasing() { }

	private void UpdateContainer() { }

}

