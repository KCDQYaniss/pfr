//Type is in global namespace

[ExecuteInEditMode]
public class BlurTextureCommandBuffer : MonoBehaviour
{
	public Shader BlurShader; //Field offset: 0x20
	private Material _material; //Field offset: 0x28
	private Camera _camera; //Field offset: 0x30
	private CommandBuffer _commandBuffer; //Field offset: 0x38

	public BlurTextureCommandBuffer() { }

	private void Cleanup() { }

	public void OnDisable() { }

	public void OnEnable() { }

	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

}

