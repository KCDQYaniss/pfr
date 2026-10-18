//Type is in global namespace

public class Spacer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0`1
	{
		public List items; //Field offset: 0x0
		public float targetDistance; //Field offset: 0x0

		public <>c__DisplayClass2_0`1() { }

		internal Group <SpaceOut>b__0(KeyValuePair item, int i) { }

	}

	private class Group`1
	{
		public float Average; //Field offset: 0x0
		private float _targetAverage; //Field offset: 0x0
		private readonly List _values; //Field offset: 0x0
		private readonly float _targetDistance; //Field offset: 0x0
		public List Items; //Field offset: 0x0

		public float LeftMost
		{
			 get { } //Length: 11
		}

		public float RightMost
		{
			 get { } //Length: 11
		}

		public Group`1(List values, float targetDistance) { }

		[CompilerGenerated]
		private int <ApplySpacing>b__12_0(int l, int r) { }

		[CompilerGenerated]
		private float <Merge>b__11_0(int index) { }

		[CompilerGenerated]
		private float <SpaceOut>b__10_0(int index) { }

		public void ApplySpacing() { }

		public float get_LeftMost() { }

		public float get_RightMost() { }

		public void Merge(Group group, float period) { }

		public void SpaceOut() { }

	}


	public Spacer() { }

	private static bool IsIntersecting(Group group1, Group group2, float targetDistance, float period) { }

	public static void SpaceOut(List items, float targetDistance, float period) { }

}

