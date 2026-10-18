namespace AbsolutDecals;

[ExecuteInEditMode]
[Obfuscation(Exclude = True)]
public class DecalProjector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <WaitAndBake>d__48 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isStaic; //Field offset: 0x20
		public DecalProjector <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <WaitAndBake>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum ProjectionDirections
	{
		PositiveX = 0,
		NegativeX = 1,
		PositiveY = 2,
		NegativeY = 3,
		PositiveZ = 4,
		NegativeZ = 5,
	}

	internal enum ProjectorState
	{
		Unbaked = 0,
		BakedToUniqueMesh = 1,
		BakedToCommonMesh = 2,
		BakedInProjectorSpace = 3,
		WaitingForSaveOnDisc = 4,
	}

	private static int _index; //Field offset: 0x0
	private static bool _locked; //Field offset: 0x4
	[SerializeField]
	public SingleDecal Decal; //Field offset: 0x20
	private ProjectionDirections _projectionDirection; //Field offset: 0x28
	[SerializeField]
	public bool ShowSelf; //Field offset: 0x2C
	[SerializeField]
	private bool _updateOnlyWhenChange; //Field offset: 0x2D
	[SerializeField]
	private bool _bakeToReusableMesh; //Field offset: 0x2E
	[CompilerGenerated]
	private bool <DontBakeInEditor>k__BackingField; //Field offset: 0x2F
	private Vector3 _bakedPosition; //Field offset: 0x30
	private MeshRenderer _meshRenderer; //Field offset: 0x40
	private MeshFilter _meshFilter; //Field offset: 0x48
	private Vector3 _prevPosition; //Field offset: 0x50
	private Vector3 _prevRotation; //Field offset: 0x5C
	[CompilerGenerated]
	private Transform <Transform>k__BackingField; //Field offset: 0x68
	[HideInInspector]
	public ProjectorState CurrentState; //Field offset: 0x70

	public bool BakedInReusableMesh
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DontBakeInEditor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ProjectionDirections ProjectionDirection
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector3 ProjectionDirectionVector
	{
		 get { } //Length: 88
	}

	public Vector3 ProjectionDirectionVectorLocal
	{
		 get { } //Length: 109
	}

	public private Transform Transform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public DecalProjector() { }

	[CompilerGenerated]
	private void <Start>b__31_0() { }

	private static void BakeDecal(Shot hit, SingleDecal decal) { }

	private static void BakeDecal(Vector3 hitPoint, Vector3 hitNormal, Collider hitCollider, SingleDecal decal) { }

	private void BakeDelayed(bool isStatic) { }

	public void BakeToMesh() { }

	public void BakeToUniqueMesh(bool inProjectorSpace = false) { }

	public static void CreateAndBakeProjector(Shot hit) { }

	private static void DrawBloodOnWall(RaycastHit hit) { }

	private void DrawGizmo(bool selected) { }

	public bool get_BakedInReusableMesh() { }

	[CompilerGenerated]
	public bool get_DontBakeInEditor() { }

	public ProjectionDirections get_ProjectionDirection() { }

	public Vector3 get_ProjectionDirectionVector() { }

	public Vector3 get_ProjectionDirectionVectorLocal() { }

	[CompilerGenerated]
	public Transform get_Transform() { }

	private void InitializeMesh() { }

	private void OnDestroy() { }

	public void OnDrawGizmos() { }

	public void OnDrawGizmosSelected() { }

	public void ResetState() { }

	public void set_BakedInReusableMesh(bool value) { }

	[CompilerGenerated]
	public void set_DontBakeInEditor(bool value) { }

	public void set_ProjectionDirection(ProjectionDirections value) { }

	[CompilerGenerated]
	private void set_Transform(Transform value) { }

	private void Start() { }

	public void UnbakeFromMesh() { }

	private void Unlock() { }

	private void Update() { }

	[IteratorStateMachine(typeof(<WaitAndBake>d__48))]
	private IEnumerator WaitAndBake(bool isStaic) { }

}

