namespace Audio.SpatialSystem.Utils;

public static class SpatialAudioCalculatorPoolFactory
{
	private static readonly Dictionary _pools; //Field offset: 0x0

	private static SpatialAudioCalculatorPoolFactory() { }

	public static void ClearPools() { }

	public static void DisposePool() { }

	public static ObjectPool GetOrCreatePool(int size, Func constructor, Action onReturnInPool = null, Action destructor = null) { }

	public static void PreCreatePool(int size, Func constructor, Action onReturnInPool = null, Action destructor = null) { }

	public static void Return(TCalculator calculator) { }

	public static TCalculator Withdraw(int size, Func constructor, Action onReturnInPool = null, Action destructor = null) { }

}

