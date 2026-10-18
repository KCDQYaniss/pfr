namespace GPUInstancer;

public class GPUInstancerRenderer
{
	public Mesh mesh; //Field offset: 0x10
	public List materials; //Field offset: 0x18
	public Matrix4x4 transformOffset; //Field offset: 0x20
	public int argsBufferOffset; //Field offset: 0x60
	public MaterialPropertyBlock mpb; //Field offset: 0x68
	public MaterialPropertyBlock shadowMPB; //Field offset: 0x70
	public int layer; //Field offset: 0x78
	public bool castShadows; //Field offset: 0x7C
	public Renderer rendererRef; //Field offset: 0x80

	public GPUInstancerRenderer() { }

}

