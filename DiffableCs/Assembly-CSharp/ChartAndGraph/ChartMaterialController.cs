namespace ChartAndGraph;

internal class ChartMaterialController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	private static bool WarnedNull; //Field offset: 0x0
	public bool HandleEvents; //Field offset: 0x20
	[SerializeField]
	private ChartDynamicMaterial materials; //Field offset: 0x28
	internal ChartItemMaterialLerpEffect mLerpEffect; //Field offset: 0x30
	private Color mLerpTo; //Field offset: 0x38
	private Color mLerpFrom; //Field offset: 0x48
	private Renderer mRenderer; //Field offset: 0x58
	private Material mMat; //Field offset: 0x60
	private Graphic mCanvasRenderer; //Field offset: 0x68
	private bool mMouseOver; //Field offset: 0x70
	private bool mMouseDown; //Field offset: 0x71
	private Nullable CombineId; //Field offset: 0x74
	private float mAccumilatedTime; //Field offset: 0x7C
	private bool mLerping; //Field offset: 0x80

	internal ChartDynamicMaterial Materials
	{
		internal get { } //Length: 5
		internal set { } //Length: 484
	}

	public ChartMaterialController() { }

	private int Combine() { }

	internal ChartDynamicMaterial get_Materials() { }

	private Color GetColorCombine(Material m) { }

	private void OnDestroy() { }

	private void OnMouseDown() { }

	private void OnMouseEnter() { }

	private void OnMouseExit() { }

	private void OnMouseUp() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void Refresh() { }

	internal void set_Materials(ChartDynamicMaterial value) { }

	private void SetColor(Color c) { }

	private void SetColorCombine(Material m, Color c) { }

	private void SetMaterial(Material m, Material fallback) { }

	private void SetRendererColor(Color c) { }

	private void Start() { }

	public void TriggerOff() { }

	public void TriggerOn() { }

	private void Update() { }

	private void WarnNullItem() { }

}

