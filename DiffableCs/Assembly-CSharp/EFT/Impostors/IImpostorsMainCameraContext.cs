namespace EFT.Impostors;

internal interface IImpostorsMainCameraContext : IImpostorsCameraContext, IDisposable
{

	public void DrawDistantShadow(CommandBuffer commandBuffer, uint impostorsPerFrame, out int impostorsRest) { }

	public void EnablesChanged() { }

	public void OnPreCull(CommandBuffer commandBuffer) { }

	public void Refresh() { }

}

