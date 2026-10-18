namespace EFT.Impostors;

[CreateAssetMenu(fileName = "ImpostorsArray", order = 86)]
public sealed class AmplifyImpostorsArray : SerializedScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__35_1; //Field offset: 0x8
		public static Func <>9__36_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetTexturesKeys>b__35_1(ResourceKey key) { }

		internal string <LoadTextures>b__36_0(ResourceKey key) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public int index; //Field offset: 0x10
		public bool failed; //Field offset: 0x14
		public IReadOnlyList ids; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal ResourceKey <GetTexturesKeys>b__0(ResourceKey key) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public IEasyAssets assets; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal Texture <LoadTextures>b__1(ResourceKey key) { }

	}

	[CompilerGenerated]
	private struct <LoadTextures>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IReadOnlyCollection keys; //Field offset: 0x20
		public IReadOnlyList ids; //Field offset: 0x28
		private <>c__DisplayClass36_0 <>8__1; //Field offset: 0x30
		private ResourceKey[] <selectedKeys>5__2; //Field offset: 0x38
		private Token <bundles>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTextures>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, "token"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ResourceKey albedoKey; //Field offset: 0x20
		public ResourceKey normalsKey; //Field offset: 0x28
		private IEasyAssets <assets>5__2; //Field offset: 0x30
		private Token <bundles>5__3; //Field offset: 0x38
		private Task <task>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegenerateMaterialQualityHigh>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, null, "token"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AmplifyImpostorsArray <>4__this; //Field offset: 0x20
		public IReadOnlyList ids; //Field offset: 0x28
		private IReadOnlyList <normalsKeys>5__2; //Field offset: 0x30
		private Texture2DArray <albedoArray>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegenerateMaterialQualityLow>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, null, "token"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AmplifyImpostorsArray <>4__this; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, "token"})]
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegenerateMaterialQualityMedium>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, null, "token"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AmplifyImpostorsArray <>4__this; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, "token"})]
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Vector3 _defaultNormal; //Field offset: 0x0
	public const int VERTEX_NUMBER = 8; //Field offset: 0x0
	private const string OCTAHEDRON_ARRAY_SHADER_GUID = "39addfe8385b88141953ea24c4e80e74"; //Field offset: 0x0
	private const string IMPOSTORS_CULLING_SHADER_GUID = "9e2596aaa367fad40a6a4a54118f6622"; //Field offset: 0x0
	[CompilerGenerated]
	private Action UnregisterEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action RegisterEvent; //Field offset: 0x60
	[HideInInspector]
	[OdinSerialize]
	public ImpostorVertex[] _vertices; //Field offset: 0x68
	[HideInInspector]
	[OdinSerialize]
	public ImpostorPropBlock[] _propBlocks; //Field offset: 0x70
	[HideInInspector]
	[OdinSerialize]
	public ImpostorBounds[] _bounds; //Field offset: 0x78
	[HideInInspector]
	[OdinSerialize]
	public Mesh _mesh; //Field offset: 0x80
	[HideInInspector]
	[OdinSerialize]
	public Material _arrayMaterial; //Field offset: 0x88
	[SerializeField]
	public Shader Shader; //Field offset: 0x90
	[SerializeField]
	public ComputeShader CullingShader; //Field offset: 0x98
	[SerializeField]
	public ResourceKey[] AlbedoKeys; //Field offset: 0xA0
	[SerializeField]
	public ResourceKey[] NormalsKeys; //Field offset: 0xA8
	[SerializeField]
	public ResourceKey Albedo1Key; //Field offset: 0xB0
	[SerializeField]
	public ResourceKey Normals1Key; //Field offset: 0xB8
	[SerializeField]
	public ResourceKey Albedo2Key; //Field offset: 0xC0
	[SerializeField]
	public ResourceKey Normals2Key; //Field offset: 0xC8

	public event Action RegisterEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action UnregisterEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public Material ArrayMaterial
	{
		 get { } //Length: 8
	}

	public ImpostorBounds[] Bounds
	{
		 get { } //Length: 5
	}

	public ImpostorPropBlock[] ImpostorPropBlocks
	{
		 get { } //Length: 5
	}

	public int Length
	{
		 get { } //Length: 17
	}

	public Mesh Mesh
	{
		 get { } //Length: 8
	}

	public ImpostorVertex[] Vertices
	{
		 get { } //Length: 5
	}

	private static AmplifyImpostorsArray() { }

	public AmplifyImpostorsArray() { }

	[CompilerGenerated]
	public void add_RegisterEvent(Action value) { }

	[CompilerGenerated]
	public void add_UnregisterEvent(Action value) { }

	private static Texture2DArray CreateTexture2DArray(IReadOnlyList textures, string name) { }

	public Material get_ArrayMaterial() { }

	public ImpostorBounds[] get_Bounds() { }

	public ImpostorPropBlock[] get_ImpostorPropBlocks() { }

	public int get_Length() { }

	public Mesh get_Mesh() { }

	public ImpostorVertex[] get_Vertices() { }

	private static string GetPostfix(ESeason season) { }

	private static string GetPostfix() { }

	private static IReadOnlyList GetResources(IReadOnlyList keys, string postfix) { }

	private static ValueTuple GetResources(ResourceKey albedo, ResourceKey normals, string postfix) { }

	private static ResourceKey[] GetTexturesKeys(IReadOnlyCollection keys, IReadOnlyList ids) { }

	[AsyncStateMachine(typeof(<LoadTextures>d__37))]
	private static Task LoadTextures(ResourceKey albedoKey, ResourceKey normalsKey) { }

	[AsyncStateMachine(typeof(<LoadTextures>d__36))]
	private static Task LoadTextures(IReadOnlyCollection keys, IReadOnlyList ids) { }

	private Material RegenerateMaterial(Texture albedoArray = null, Texture normalsArray = null, Material template = null) { }

	[AsyncStateMachine(typeof(<RegenerateMaterialQualityHigh>d__44))]
	internal Task RegenerateMaterialQualityHigh(IReadOnlyList ids) { }

	[AsyncStateMachine(typeof(<RegenerateMaterialQualityLow>d__46))]
	internal Task RegenerateMaterialQualityLow() { }

	[AsyncStateMachine(typeof(<RegenerateMaterialQualityMedium>d__45))]
	internal Task RegenerateMaterialQualityMedium() { }

	[CompilerGenerated]
	public void remove_RegisterEvent(Action value) { }

	[CompilerGenerated]
	public void remove_UnregisterEvent(Action value) { }

}

