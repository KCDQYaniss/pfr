namespace UnityEngine.Rendering.PostProcessing;

public abstract class Monitor
{
	[CompilerGenerated]
	private RenderTexture <output>k__BackingField; //Field offset: 0x10
	internal bool requested; //Field offset: 0x18

	public RenderTexture output
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected Monitor() { }

	protected void CheckOutput(int width, int height) { }

	[CompilerGenerated]
	public RenderTexture get_output() { }

	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	internal override bool NeedsHalfRes() { }

	internal override void OnDisable() { }

	internal override void OnEnable() { }

	internal abstract void Render(PostProcessRenderContext context) { }

	[CompilerGenerated]
	protected void set_output(RenderTexture value) { }

	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

