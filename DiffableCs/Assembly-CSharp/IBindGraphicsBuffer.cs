//Type is in global namespace

public interface IBindGraphicsBuffer
{

	public void BindTo(CommandBuffer buffer) { }

	public void BindTo(Material material) { }

	public void BindTo(CommandBuffer buffer, ComputeShader shader) { }

	public bool UnbindFrom(Material material) { }

	public bool UnbindFrom(CommandBuffer buffer) { }

	public bool UnbindFrom(ComputeShader shader) { }

	public bool UnbindFrom(MaterialPropertyBlock block) { }

}

