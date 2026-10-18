namespace EFT;

public class ExtendedPlayerOwner : PlayerOwner
{
	private sealed class MockedInputTree : IInputTree
	{

		public MockedInputTree() { }

		public override void Add(InputNode node) { }

		public override void AddWithLowPriority(InputNode node) { }

		public override bool Contains(InputNode node) { }

		public override void Remove(InputNode node) { }

	}


	public ExtendedPlayerOwner() { }

	internal static ExtendedPlayerOwner Create(Player player) { }

	public ECursorResult ExtendedShouldLockCursor() { }

	public void ExtendedTranslateAxes(ref float[] axes) { }

	public ETranslateResult ExtendedTranslateCommand(ECommand command) { }

}

