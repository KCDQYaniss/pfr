namespace Coffee.UISoftMask;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
public class MaskingShapeContainer : MonoBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__6_0(MaskingShape x) { }

	}

	[SerializeField]
	private List m_MaskingShapes; //Field offset: 0x20
	private Action _checkTransformChanged; //Field offset: 0x28
	private bool _dirty; //Field offset: 0x30
	private Mask _mask; //Field offset: 0x38
	private bool _needTerminal; //Field offset: 0x40
	private TerminalMaskingShape _terminal; //Field offset: 0x48

	public MaskingShapeContainer() { }

	private void CheckTransformChanged() { }

	public void DrawSoftMaskBuffer(CommandBuffer cb, int softMaskDepth) { }

	private TerminalMaskingShape FindTerminal() { }

	public bool IsInScreen() { }

	public bool IsInside(Vector2 sp, Camera eventCamera, bool defaultValid = false, float threshold = 0.01) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Register(MaskingShape shape) { }

	public void SetContainerDirty() { }

	private override bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	private override Material UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(Material baseMaterial) { }

	public void Unregister(MaskingShape shape) { }

}

