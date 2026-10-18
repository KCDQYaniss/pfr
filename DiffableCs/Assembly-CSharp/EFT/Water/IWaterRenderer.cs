namespace EFT.Water;

public interface IWaterRenderer
{

	public bool Enabled
	{
		 get { } //Length: 0
	}

	public void Cleanup(CommandBuffer cmd) { }

	public bool get_Enabled() { }

	public void Render(Camera camera, CommandBuffer cmd) { }

}

