namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessBundle
{
	[CompilerGenerated]
	private PostProcessAttribute <attribute>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private PostProcessEffectSettings <settings>k__BackingField; //Field offset: 0x18
	private PostProcessEffectRenderer m_Renderer; //Field offset: 0x20

	public private PostProcessAttribute attribute
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal PostProcessEffectRenderer renderer
	{
		internal get { } //Length: 366
	}

	public private PostProcessEffectSettings settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal PostProcessBundle(PostProcessEffectSettings settings) { }

	internal T CastRenderer() { }

	internal T CastSettings() { }

	[CompilerGenerated]
	public PostProcessAttribute get_attribute() { }

	internal PostProcessEffectRenderer get_renderer() { }

	[CompilerGenerated]
	public PostProcessEffectSettings get_settings() { }

	internal void Release() { }

	internal void ResetHistory() { }

	[CompilerGenerated]
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGenerated]
	private void set_settings(PostProcessEffectSettings value) { }

}

