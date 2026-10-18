namespace EFT;

public struct AnimatorFootprint : IDisposable
{
	private static Stack _listPool; //Field offset: 0x0
	public AnimatorStateFootprint[] layersFootprint; //Field offset: 0x0

	private static AnimatorFootprint() { }

	private static void AddListToPool(AnimatorStateFootprint[] list) { }

	public static AnimatorFootprint Create(int layersFootprintLength) { }

	public static AnimatorFootprint Create(IAnimator animator) { }

	public override void Dispose() { }

	private static AnimatorStateFootprint[] GetListFromPool(int capacity) { }

}

