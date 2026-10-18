//Type is in global namespace

public class FSRWrapper
{
	private ComputeShader _easuShader; //Field offset: 0x10
	private ComputeShader _rcasShader; //Field offset: 0x18
	private CommandBuffer _cmdBuf; //Field offset: 0x20
	private RenderTexture _dstBuf; //Field offset: 0x28
	private ComputeBuffer easuParameterBuffer; //Field offset: 0x30
	private ComputeBuffer casParametersBuffer; //Field offset: 0x38

	public FSRWrapper(ComputeShader EASUShader, ComputeShader RCASShader) { }

	public RenderTexture PrepareOutput(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

}

