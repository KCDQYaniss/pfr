namespace EFT.Prestige;

public sealed class ImageData
{
	private readonly string _imageUrl; //Field offset: 0x10

	public ImageData(string imageUrl) { }

	public Task GetAndAssignImage(IImageLoader imageLoader, Image image, bool resetImage, CancellationToken cancellationToken) { }

}

