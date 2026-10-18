namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessProfile : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__2_0(PostProcessEffectSettings x) { }

	}

	[Tooltip("A list of all settings currently stored in this profile.")]
	public List settings; //Field offset: 0x18
	public bool isDirty; //Field offset: 0x20

	public PostProcessProfile() { }

	public T AddSettings() { }

	public PostProcessEffectSettings AddSettings(Type type) { }

	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	public T GetSetting() { }

	public bool HasSettings() { }

	public bool HasSettings(Type type) { }

	private void OnEnable() { }

	public void RemoveSettings() { }

	public void RemoveSettings(Type type) { }

	public bool TryGetSettings(out T outSetting) { }

}

