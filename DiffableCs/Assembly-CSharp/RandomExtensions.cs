//Type is in global namespace

[Extension]
public static class RandomExtensions
{

	public static void Shuffle(T[] array) { }

	[Extension]
	public static void Shuffle(Random rng, T[] array) { }

}

