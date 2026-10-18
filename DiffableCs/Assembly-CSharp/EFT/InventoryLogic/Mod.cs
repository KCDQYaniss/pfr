namespace EFT.InventoryLogic;

public class Mod : CompoundItem, IMoveCheckable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__36_2; //Field offset: 0x8
		public static Func <>9__36_4; //Field offset: 0x10
		public static Func <>9__36_6; //Field offset: 0x18
		public static Func <>9__36_9; //Field offset: 0x20
		public static Func <>9__36_12; //Field offset: 0x28
		public static Func <>9__36_15; //Field offset: 0x30
		public static Func <>9__36_17; //Field offset: 0x38
		public static Func <>9__36_19; //Field offset: 0x40
		public static Func <>9__36_22; //Field offset: 0x48
		public static Func <>9__36_25; //Field offset: 0x50
		public static Func <>9__36_28; //Field offset: 0x58

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__36_12() { }

		internal EItemAttributeDisplayType <.ctor>b__36_15() { }

		internal EItemAttributeDisplayType <.ctor>b__36_17() { }

		internal EItemAttributeDisplayType <.ctor>b__36_19() { }

		internal EItemAttributeDisplayType <.ctor>b__36_2() { }

		internal EItemAttributeDisplayType <.ctor>b__36_22() { }

		internal EItemAttributeDisplayType <.ctor>b__36_25() { }

		internal EItemAttributeDisplayType <.ctor>b__36_28() { }

		internal EItemAttributeDisplayType <.ctor>b__36_4() { }

		internal EItemAttributeDisplayType <.ctor>b__36_6() { }

		internal EItemAttributeDisplayType <.ctor>b__36_9() { }

	}

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__38 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Mod <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <get_ItemInteractionButtons>d__38(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.EItemInfoButton>.GetEnumerator() { }

		[DebuggerHidden]
		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public int Accuracy
	{
		 get { } //Length: 79
	}

	public bool BlocksFolding
	{
		 get { } //Length: 80
	}

	public int CategoryAnimationModId
	{
		 get { } //Length: 79
	}

	public override float CoolFactor
	{
		 get { } //Length: 9
	}

	public float DoubleActionAccuracyPenaltyMult
	{
		 get { } //Length: 81
	}

	public override float DurabilityBurnModificator
	{
		 get { } //Length: 9
	}

	public int EffectiveDistance
	{
		 get { } //Length: 79
	}

	public float Ergonomics
	{
		 get { } //Length: 81
	}

	public override bool HasLightComponent
	{
		 get { } //Length: 3
	}

	public override float HeatFactor
	{
		 get { } //Length: 9
	}

	public bool IsAnimated
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__38))]
		 get { } //Length: 175
	}

	public int Loudness
	{
		 get { } //Length: 79
	}

	public bool RaidModdable
	{
		 get { } //Length: 80
	}

	public float Recoil
	{
		 get { } //Length: 81
	}

	public float SightingRange
	{
		 get { } //Length: 81
	}

	public ModTemplate Template
	{
		 get { } //Length: 62
	}

	public bool ToolModdable
	{
		 get { } //Length: 80
	}

	public int UniqueAnimationModID
	{
		 get { } //Length: 79
	}

	public float Velocity
	{
		 get { } //Length: 81
	}

	public Mod(string id, ModTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__36_0() { }

	[CompilerGenerated]
	private string <.ctor>b__36_1() { }

	[CompilerGenerated]
	private float <.ctor>b__36_10() { }

	[CompilerGenerated]
	private string <.ctor>b__36_11() { }

	[CompilerGenerated]
	private float <.ctor>b__36_13() { }

	[CompilerGenerated]
	private string <.ctor>b__36_14() { }

	[CompilerGenerated]
	private float <.ctor>b__36_16() { }

	[CompilerGenerated]
	private float <.ctor>b__36_18() { }

	[CompilerGenerated]
	private float <.ctor>b__36_20() { }

	[CompilerGenerated]
	private string <.ctor>b__36_21() { }

	[CompilerGenerated]
	private float <.ctor>b__36_23() { }

	[CompilerGenerated]
	private string <.ctor>b__36_24() { }

	[CompilerGenerated]
	private float <.ctor>b__36_26() { }

	[CompilerGenerated]
	private string <.ctor>b__36_27() { }

	[CompilerGenerated]
	private float <.ctor>b__36_3() { }

	[CompilerGenerated]
	private float <.ctor>b__36_5() { }

	[CompilerGenerated]
	private float <.ctor>b__36_7() { }

	[CompilerGenerated]
	private string <.ctor>b__36_8() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	public override Option CanBeMoved(IContainer toContainer) { }

	public virtual bool Compare(Item item) { }

	public int get_Accuracy() { }

	public bool get_BlocksFolding() { }

	public int get_CategoryAnimationModId() { }

	public override float get_CoolFactor() { }

	public float get_DoubleActionAccuracyPenaltyMult() { }

	public override float get_DurabilityBurnModificator() { }

	public int get_EffectiveDistance() { }

	public float get_Ergonomics() { }

	public override bool get_HasLightComponent() { }

	public override float get_HeatFactor() { }

	public bool get_IsAnimated() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__38))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	public int get_Loudness() { }

	public bool get_RaidModdable() { }

	public float get_Recoil() { }

	public float get_SightingRange() { }

	public ModTemplate get_Template() { }

	public bool get_ToolModdable() { }

	public int get_UniqueAnimationModID() { }

	public float get_Velocity() { }

	public IEnumerable GetSuitableWeapons(CompoundItem[] collections) { }

}

