namespace GPUInstancer;

public class GPUInstancerPrototypeLOD
{
	public List renderers; //Field offset: 0x10
	public ComputeBuffer transformationMatrixAppendBuffer; //Field offset: 0x18
	public ComputeBuffer shadowAppendBuffer; //Field offset: 0x20
	public bool excludeBounds; //Field offset: 0x28
	public RenderTexture transformationMatrixAppendTexture; //Field offset: 0x30
	public RenderTexture shadowAppendTexture; //Field offset: 0x38

	public int argsBufferOffset
	{
		 get { } //Length: 141
	}

	public GPUInstancerPrototypeLOD() { }

	public int get_argsBufferOffset() { }

}

