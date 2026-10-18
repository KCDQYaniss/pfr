//Type is in global namespace

[AddComponentMenu(null)]
public class AmplifyMotionObjectBase : MonoBehaviour
{
	internal enum MinMaxCurveState
	{
		Scalar = 0,
		Curve = 1,
		TwoCurves = 2,
		TwoScalars = 3,
	}

	internal static bool ApplyToChildren; //Field offset: 0x0
	[SerializeField]
	private bool m_applyToChildren; //Field offset: 0x20
	private ObjectType m_type; //Field offset: 0x24
	private Dictionary m_states; //Field offset: 0x28
	private bool m_fixedStep; //Field offset: 0x30
	private int m_objectId; //Field offset: 0x34
	private Vector3 m_lastPosition; //Field offset: 0x38
	private int m_resetAtFrame; //Field offset: 0x44

	internal bool FixedStep
	{
		internal get { } //Length: 5
	}

	internal int ObjectId
	{
		internal get { } //Length: 4
	}

	public ObjectType Type
	{
		 get { } //Length: 4
	}

	private static AmplifyMotionObjectBase() { }

	public AmplifyMotionObjectBase() { }

	private void CheckTeleportReset(AmplifyMotionEffectBase inst) { }

	internal bool get_FixedStep() { }

	internal int get_ObjectId() { }

	public ObjectType get_Type() { }

	private bool InitializeType() { }

	private void OnDisable() { }

	private void OnEnable() { }

	internal void OnRenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal void OnUpdateTransform(AmplifyMotionEffectBase inst, Camera camera, CommandBuffer updateCB, bool starting) { }

	private static void RecursiveResetMotionAtFrame(Transform transform, AmplifyMotionObjectBase obj, int frame) { }

	internal void RegisterCamera(AmplifyMotionCamera camera) { }

	public void ResetMotionAtFrame(int frame) { }

	public void ResetMotionNow() { }

	private void Start() { }

	private void TryInitializeStates() { }

	internal void UnregisterCamera(AmplifyMotionCamera camera) { }

	private void Update() { }

}

