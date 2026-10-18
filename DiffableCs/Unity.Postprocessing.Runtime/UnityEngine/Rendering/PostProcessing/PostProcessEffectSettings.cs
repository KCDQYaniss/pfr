namespace UnityEngine.Rendering.PostProcessing;

public class PostProcessEffectSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__3_0(FieldInfo t) { }

		internal int <OnEnable>b__3_1(FieldInfo t) { }

	}

	public bool active; //Field offset: 0x18
	public BoolParameter enabled; //Field offset: 0x20
	internal ReadOnlyCollection parameters; //Field offset: 0x28

	public PostProcessEffectSettings() { }

	[CompilerGenerated]
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

	public int GetHash() { }

	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void SetAllOverridesTo(bool state, bool excludeEnabled = true) { }

}

