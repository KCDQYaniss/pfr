//Type is in global namespace

public class Skinner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Skin>b__1_0(Transform x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Dictionary skinBonesDictionary; //Field offset: 0x10
		public bool removeSpaceOne; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal bool <Skin>b__1(Transform transform) { }

		internal KeyValuePair <Skin>b__2(Transform bone) { }

	}


	public Skinner() { }

	private static SkinnedMeshRenderer ApplyMesh(SkinnedMeshRenderer source, Dictionary bindedTransforms, Transform targetRoot) { }

	private static string GetRealName(string name) { }

	private static void InsertAtPath(GameObject target, Transform targetRoot, string path) { }

	public static SkinnedMeshRenderer Skin(SkinnedMeshRenderer renderer, Transform target, bool removeSpaceOne = false) { }

}

