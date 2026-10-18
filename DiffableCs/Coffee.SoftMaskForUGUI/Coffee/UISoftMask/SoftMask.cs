namespace Coffee.UISoftMask;

[DisallowMultipleComponent]
[ExecuteAlways]
public class SoftMask : Mask, ISoftMasking, IMeshModifier, IMaskable, IMaskingShapeContainerOwner, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__60_0; //Field offset: 0x8
		public static Predicate <>9__100_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal RenderTexture <get_softMaskBuffer>b__60_0(Vector2Int x) { }

		internal bool <UpdateParentSoftMask>b__100_0(SoftMask x) { }

	}

	internal enum DownSamplingRate
	{
		None = 0,
		x1 = 1,
		x2 = 2,
		x4 = 4,
		x8 = 8,
	}

	internal enum MaskingMode
	{
		SoftMasking = 0,
		AntiAliasing = 1,
		Normal = 2,
	}

	public static Action onRenderSoftMaskBuffer; //Field offset: 0x0
	private static readonly MonoOrStereoscopicEye[] s_MonoEyes; //Field offset: 0x8
	private static readonly MonoOrStereoscopicEye[] s_StereoEyes; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Masking mode.\n\nSoftMasking: Use RenderTexture as a soft mask buffer. The alpha of the masking graphic can be used.\nAntiAliasing: Suppress the jaggedness of the masking graphic. The masking graphic cannot be displayed.\nNormal: Same as Mask component's stencil mask.")]
	private MaskingMode m_MaskingMode; //Field offset: 0x48
	[SerializeField]
	[Tooltip("The transparent part of the mask cannot be clicked.\nThis can be achieved by enabling Read/Write enabled in the Texture Import Settings for the texture.\n\nNOTE: Enable this only if necessary, as it will require more graphics memory and processing time.")]
	private bool m_AlphaHitTest; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("The minimum and maximum alpha values used for soft masking.\nThe larger the gap between these values, the stronger the softness effect.")]
	private MinMax01 m_SoftnessRange; //Field offset: 0x50
	[SerializeField]
	[Tooltip("The down sampling rate for soft mask buffer.\nThe higher this value, the lower the quality of the soft masking, but the performance will improve.")]
	private DownSamplingRate m_DownSamplingRate; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The threshold for anti-alias masking.\nThe smaller this value, the less jagged it is.")]
	private float m_AntiAliasingThreshold; //Field offset: 0x5C
	[Obsolete]
	[SerializeField]
	internal float m_Alpha; //Field offset: 0x60
	[Obsolete]
	[SerializeField]
	internal float m_Softness; //Field offset: 0x64
	[Obsolete]
	[SerializeField]
	private bool m_PartOfParent; //Field offset: 0x68
	private CanvasGroup _canvasGroup; //Field offset: 0x70
	private CommandBuffer _cb; //Field offset: 0x78
	private List _children; //Field offset: 0x80
	private bool _hasResolutionChanged; //Field offset: 0x88
	private bool _hasSoftMaskBufferDrawn; //Field offset: 0x89
	private Mesh _mesh; //Field offset: 0x90
	private MaterialPropertyBlock _mpb; //Field offset: 0x98
	private Action _onBeforeCanvasRebuild; //Field offset: 0xA0
	private Action _onCanvasViewChanged; //Field offset: 0xA8
	private SoftMask _parent; //Field offset: 0xB0
	private Matrix4x4 _prevTransformMatrix; //Field offset: 0xB8
	private Action _renderSoftMaskBuffer; //Field offset: 0xF8
	private Canvas _rootCanvas; //Field offset: 0x100
	private UnityAction _setSoftMaskDirty; //Field offset: 0x108
	private MaskingShapeContainer _shapeContainer; //Field offset: 0x110
	internal RenderTexture _softMaskBuffer; //Field offset: 0x118
	private UnityAction _updateParentSoftMask; //Field offset: 0x120
	private CanvasViewChangeTrigger _viewChangeTrigger; //Field offset: 0x128
	[CompilerGenerated]
	private Color <clearColor>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private bool <isDirty>k__BackingField; //Field offset: 0x140

	public bool allowDynamicResolution
	{
		 get { } //Length: 475
	}

	public bool allowRenderScale
	{
		 get { } //Length: 3
	}

	public override bool alphaHitTest
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override float antiAliasingThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	private List children
	{
		private get { } //Length: 170
	}

	public Color clearColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public DownSamplingRate downSamplingRate
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public bool hasSoftMaskBuffer
	{
		 get { } //Length: 206
	}

	public private bool isDirty
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override MaskingMethod maskingMethod
	{
		 get { } //Length: 3
	}

	public MaskingMode maskingMode
	{
		 get { } //Length: 4
		 set { } //Length: 298
	}

	[Obsolete("Use MaskingShape component instead.", False)]
	public bool partOfParent
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override RaycastMethod raycastMethod
	{
		 get { } //Length: 6
	}

	public RenderTexture softMaskBuffer
	{
		 get { } //Length: 1199
	}

	public int softMaskDepth
	{
		 get { } //Length: 280
	}

	[Obsolete("Use softnessRange instead.", False)]
	public float softness
	{
		 get { } //Length: 6
		 set { } //Length: 175
	}

	public override MinMax01 softnessRange
	{
		 get { } //Length: 19
		 set { } //Length: 88
	}

	private static SoftMask() { }

	public SoftMask() { }

	private void AddSoftMaskableOnChildren() { }

	public bool AntiAliasingEnabled() { }

	private override void Coffee.UISoftMask.IMaskingShapeContainerOwner.Register(MaskingShapeContainer container) { }

	private override bool Coffee.UISoftMask.ISoftMasking.get_enabled() { }

	private override bool Coffee.UISoftMask.ISoftMasking.get_showMaskGraphic() { }

	public bool get_allowDynamicResolution() { }

	public bool get_allowRenderScale() { }

	public override bool get_alphaHitTest() { }

	public override float get_antiAliasingThreshold() { }

	private List get_children() { }

	[CompilerGenerated]
	public Color get_clearColor() { }

	public DownSamplingRate get_downSamplingRate() { }

	public bool get_hasSoftMaskBuffer() { }

	[CompilerGenerated]
	public bool get_isDirty() { }

	public override MaskingMethod get_maskingMethod() { }

	public MaskingMode get_maskingMode() { }

	public bool get_partOfParent() { }

	public override RaycastMethod get_raycastMethod() { }

	public RenderTexture get_softMaskBuffer() { }

	public int get_softMaskDepth() { }

	public float get_softness() { }

	public override MinMax01 get_softnessRange() { }

	internal MaskingMode GetActualMaskingMode() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	private bool IsInScreen() { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	private void OnBeforeCanvasRebuild() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	private void OnCanvasViewChanged() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected void OnTransformChildrenChanged() { }

	protected virtual void OnTransformParentChanged() { }

	private void RenderSoftMaskBuffer(CommandBuffer cb, MonoOrStereoscopicEye eye) { }

	private void RenderSoftMaskBuffer() { }

	public void set_alphaHitTest(bool value) { }

	public void set_antiAliasingThreshold(float value) { }

	[CompilerGenerated]
	public void set_clearColor(Color value) { }

	public void set_downSamplingRate(DownSamplingRate value) { }

	[CompilerGenerated]
	private void set_isDirty(bool value) { }

	public void set_maskingMode(MaskingMode value) { }

	public void set_partOfParent(bool value) { }

	public void set_softness(float value) { }

	public void set_softnessRange(MinMax01 value) { }

	private void SetDirtyAndNotify() { }

	private void SetDirtyAndNotifyIfBufferSizeChanged() { }

	public void SetSoftMaskDirty() { }

	public bool SoftMaskingEnabled() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private override void UnityEngine.UI.IMaskable.RecalculateMasking() { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(VertexHelper verts) { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(Mesh mesh) { }

	private void UpdateAntiAlias() { }

	private void UpdateCanvasViewChangeTrigger(CanvasViewChangeTrigger trigger) { }

	private void UpdateParentSoftMask(SoftMask newParent) { }

	private void UpdateParentSoftMask() { }

}

