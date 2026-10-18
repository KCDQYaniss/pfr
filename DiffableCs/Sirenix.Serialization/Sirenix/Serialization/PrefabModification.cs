namespace Sirenix.Serialization;

public sealed class PrefabModification
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8
		public static Func <>9__16_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetInstanceOfStep>b__13_0(MemberInfo n) { }

		internal bool <TrySetInstanceOfStep>b__16_0(MemberInfo n) { }

	}

	public PrefabModificationType ModificationType; //Field offset: 0x10
	public string Path; //Field offset: 0x18
	public List ReferencePaths; //Field offset: 0x20
	public object ModifiedValue; //Field offset: 0x28
	public int NewLength; //Field offset: 0x30
	public object[] DictionaryKeysAdded; //Field offset: 0x38
	public object[] DictionaryKeysRemoved; //Field offset: 0x40

	public PrefabModification() { }

	public void Apply(Object unityObject) { }

	private void ApplyDictionaryModifications(Object unityObject) { }

	private void ApplyListLength(Object unityObject) { }

	private void ApplyValue(Object unityObject) { }

	private static object GetInstanceFromPath(string path, object instance) { }

	private static object GetInstanceOfStep(string step, object instance) { }

	private static void ReplaceAllReferencesInGraph(object graph, object oldReference, object newReference, HashSet processedReferences = null) { }

	private static void SetInstanceToPath(string path, object instance, object value) { }

	private static void SetInstanceToPath(string path, string[] steps, int index, object instance, object value, out bool setParentInstance) { }

	private static bool TrySetInstanceOfStep(string step, object instance, object value, out bool setParentInstance) { }

}

