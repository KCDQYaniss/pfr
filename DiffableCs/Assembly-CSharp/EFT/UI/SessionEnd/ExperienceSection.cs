namespace EFT.UI.SessionEnd;

public class ExperienceSection : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <get_Sum>b__10_0(ExperienceArticle x) { }

	}

	public readonly string Name; //Field offset: 0x10
	public readonly List Articles; //Field offset: 0x18
	private readonly EStatGroupId _groupId; //Field offset: 0x20

	public Sprite Icon
	{
		 get { } //Length: 54
	}

	public int Sum
	{
		 get { } //Length: 387
	}

	public ExperienceSection(string name, EStatGroupId groupId) { }

	public void Add(string name, int value) { }

	public Sprite get_Icon() { }

	public int get_Sum() { }

	public override IEnumerator GetEnumerator() { }

	public override string SumText() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override void ValidateExpIcon(PlayerExperienceIcon expIcon) { }

}

