namespace EFT.Impostors;

internal sealed class ImpostorsOpticCameraContext : ImpostorsCameraContextAbstract, IImpostorsOpticCameraContext, IImpostorsCameraContext, IDisposable
{
	private IImpostorsMainCameraContext _mainCameraContext; //Field offset: 0x20

	internal ImpostorsOpticCameraContext(Camera camera, IImpostorsMainCameraContext mainCameraContext) { }

	public virtual void Dispose() { }

	private override void EFT.Impostors.IImpostorsCameraContext.OnPreCull() { }

}

