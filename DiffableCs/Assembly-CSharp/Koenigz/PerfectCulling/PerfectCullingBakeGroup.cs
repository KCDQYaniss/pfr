namespace Koenigz.PerfectCulling;

public class PerfectCullingBakeGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Renderer rend; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <ContainsRenderer>b__0(Renderer x) { }

	}

	[CompilerGenerated]
	private sealed class <get_EnumerateCenters>d__29 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Vector3 <>2__current; //Field offset: 0x14
		public PerfectCullingBakeGroup <>4__this; //Field offset: 0x20
		private RuntimeGroupContent[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private Light[] <>7__wrap3; //Field offset: 0x38
		private Renderer[] <>7__wrap4; //Field offset: 0x40
		private CullingObject[] <>7__wrap5; //Field offset: 0x48

		private override Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 83
		}

		[DebuggerHidden]
		public <get_EnumerateCenters>d__29(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum GroupType
	{
		Other = 0,
		LOD = 1,
		User = 2,
		Light = 3,
		CullingLightObject = 4,
		Door = 5,
		Portal = 6,
		CullingCell = 7,
		BakedLod = 8,
	}

	[IsReadOnly]
	internal struct RuntimeGroupContent
	{
		public readonly Renderer Renderer; //Field offset: 0x0
		public readonly ShadowCastingMode ShadowCastingMode; //Field offset: 0x8
		public readonly GameObject RendererObj; //Field offset: 0x10
		public readonly string RendererObjName; //Field offset: 0x18

		public RuntimeGroupContent(Renderer renderer, ShadowCastingMode shadowCastingMode) { }

	}

	public static int numPersistentShadowLods; //Field offset: 0x0
	public const float PERSISTENT_SHADOW_OBJ_SIZE = 2.5; //Field offset: 0x0
	public GroupType groupType; //Field offset: 0x10
	public Renderer[] renderers; //Field offset: 0x18
	public ScreenDistanceSwitcher screenDistanceSwitcher; //Field offset: 0x20
	public EOccludeMode occludeMode; //Field offset: 0x28
	public int serializedGroupId; //Field offset: 0x2C
	public float lightBakeSize; //Field offset: 0x30
	public Vector3 lightBakePosition; //Field offset: 0x34
	public Vector3 lightDir; //Field offset: 0x40
	public float lightAngle; //Field offset: 0x4C
	public LightType lightType; //Field offset: 0x50
	public CullingObject[] cullingLightObjects; //Field offset: 0x58
	public AnalyticSource[] analyticSources; //Field offset: 0x60
	public int vertexCount; //Field offset: 0x68
	public ushort runtimeGroupIndex; //Field offset: 0x6C
	public int updateCounter; //Field offset: 0x70
	public Renderer[] runtimeProxies; //Field offset: 0x78
	public LODGroup runtimeLodGroup; //Field offset: 0x80
	private int runtimeGroupDataSize; //Field offset: 0x88
	private RuntimeGroupContent[] runtimeGroupData; //Field offset: 0x90
	public bool isGroupEnabled; //Field offset: 0x98
	public Light[] runtimeLights; //Field offset: 0xA0

	public IEnumerator EnumerateCenters
	{
		[IteratorStateMachine(typeof(<get_EnumerateCenters>d__29))]
		 get { } //Length: 154
	}

	public bool IsEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 11
	}

	public RuntimeGroupContent[] RuntimeGroupData
	{
		 get { } //Length: 8
	}

	public float Volume
	{
		 get { } //Length: 618
	}

	public PerfectCullingBakeGroup() { }

	public bool ContainsRenderer(Renderer rend) { }

	public bool ContainsRenderers() { }

	internal void CreateAutoTestProxies() { }

	public void CreateRuntimeProxies() { }

	public void DeleteRuntimeProxies() { }

	public void ForeachRenderer(Action actionForRenderer) { }

	[IteratorStateMachine(typeof(<get_EnumerateCenters>d__29))]
	public IEnumerator get_EnumerateCenters() { }

	public bool get_IsEnabled() { }

	public RuntimeGroupContent[] get_RuntimeGroupData() { }

	public float get_Volume() { }

	private Bounds GetAnyValidBounds() { }

	public Vector3 GetCenter() { }

	public ValueTuple GetGroupBounds() { }

	public float GetVisualVerticalSize() { }

	public int Init() { }

	private RuntimeGroupContent PopRuntimeGroupContent() { }

	public bool PopRuntimeRenderer(Renderer renderer) { }

	private void PushRuntimeGroupContent(RuntimeGroupContent groupContent) { }

	public void PushRuntimeRenderer(Renderer renderer) { }

	public void RuntimeSetForceRenderingOff(bool forceRenderingOff) { }

	public void set_IsEnabled(bool value) { }

	public void Toggle(bool rendererEnabled) { }

	public LODGroup TryGetLODGroupFromRenderersHierarchyUpwards() { }

	internal LODGroup TryGetParentLODGroup() { }

	public void ValidateRuntime() { }

}

