namespace Coffee.UISoftMask;

[ExecuteAlways]
public class SoftMaskable : MonoBehaviour, IMaterialModifier, IMaskable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Material <UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__39_0(Material x) { }

	}

	private static readonly int s_SoftMaskableStereo; //Field offset: 0x0
	private const float k_PowerMin = 0.5; //Field offset: 0x0
	private const float k_PowerMax = 5; //Field offset: 0x0
	private static readonly int s_SoftMaskOutsideColor; //Field offset: 0x4
	private static readonly int s_SoftMaskTex; //Field offset: 0x8
	private static readonly int s_SoftMaskColor; //Field offset: 0xC
	private static readonly int s_AllowDynamicResolution; //Field offset: 0x10
	private static readonly int s_AllowRenderScale; //Field offset: 0x14
	private static readonly int s_SoftMaskingPower; //Field offset: 0x18
	[SerializeField]
	[Tooltip("The graphic is ignored when soft-masking.")]
	private bool m_IgnoreSelf; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The child graphics are ignored when soft-masking.")]
	private bool m_IgnoreChildren; //Field offset: 0x21
	[SerializeField]
	[Tooltip("Soft masking power.\nThe higher this value, the faster it becomes transparent.\nIf overlapping objects appear see-through, please adjust this value.")]
	private float m_Power; //Field offset: 0x24
	private Action _checkGraphic; //Field offset: 0x28
	private MaskableGraphic _graphic; //Field offset: 0x30
	private Material _maskableMaterial; //Field offset: 0x38
	private bool _shouldRecalculateStencil; //Field offset: 0x40
	private Mask _mask; //Field offset: 0x48
	private SoftMask _softMask; //Field offset: 0x50
	private int _softMaskDepth; //Field offset: 0x58
	private int _stencilBits; //Field offset: 0x5C

	public bool ignoreChildren
	{
		 get { } //Length: 5
		 set { } //Length: 45
	}

	public bool ignored
	{
		 get { } //Length: 691
	}

	public bool ignoreSelf
	{
		 get { } //Length: 5
		 set { } //Length: 45
	}

	private bool isTerminal
	{
		private get { } //Length: 122
	}

	public float power
	{
		 get { } //Length: 6
		 set { } //Length: 89
	}

	private static SoftMaskable() { }

	public SoftMaskable() { }

	private void CheckGraphic() { }

	public bool get_ignoreChildren() { }

	public bool get_ignored() { }

	public bool get_ignoreSelf() { }

	private bool get_isTerminal() { }

	public float get_power() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnTransformChildrenChanged() { }

	private void OnTransformParentChanged() { }

	private void RecalculateStencilIfNeeded() { }

	internal void ReleaseMaterial() { }

	public void set_ignoreChildren(bool value) { }

	public void set_ignoreSelf(bool value) { }

	public void set_power(float value) { }

	public void SetMaterialDirty() { }

	public void SetMaterialDirtyForChildren() { }

	private override void UnityEngine.UI.IMaskable.RecalculateMasking() { }

	private override Material UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(Material baseMaterial) { }

	private void UpdateHideFlags() { }

}

