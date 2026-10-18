namespace Cinemachine;

internal static class ClipperLib
{
	internal class Clipper : ClipperBase
	{
		public enum NodeType
		{
			ntAny = 0,
			ntOpen = 1,
			ntClosed = 2,
		}

		public const int ioReverseSolution = 1; //Field offset: 0x0
		public const int ioStrictlySimple = 2; //Field offset: 0x0
		public const int ioPreserveCollinear = 4; //Field offset: 0x0
		private ClipType m_ClipType; //Field offset: 0x48
		private Maxima m_Maxima; //Field offset: 0x50
		private TEdge m_SortedEdges; //Field offset: 0x58
		private List m_IntersectList; //Field offset: 0x60
		private IComparer m_IntersectNodeComparer; //Field offset: 0x68
		private bool m_ExecuteLocked; //Field offset: 0x70
		private PolyFillType m_ClipFillType; //Field offset: 0x74
		private PolyFillType m_SubjFillType; //Field offset: 0x78
		private List m_Joins; //Field offset: 0x80
		private List m_GhostJoins; //Field offset: 0x88
		private bool m_UsingPolyTree; //Field offset: 0x90
		[CompilerGenerated]
		private bool <ReverseSolution>k__BackingField; //Field offset: 0x91
		[CompilerGenerated]
		private bool <StrictlySimple>k__BackingField; //Field offset: 0x92

		public bool ReverseSolution
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public bool StrictlySimple
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public Clipper(int InitOptions = 0) { }

		private void AddEdgeToSEL(TEdge edge) { }

		private void AddGhostJoin(OutPt Op, IntPoint OffPt) { }

		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) { }

		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) { }

		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) { }

		private OutPt AddOutPt(TEdge e, IntPoint pt) { }

		internal static void AddPolyNodeToPaths(PolyNode polynode, NodeType nt, List paths) { }

		private void AppendPolygon(TEdge e1, TEdge e2) { }

		internal double Area(OutPt op) { }

		internal double Area(OutRec outRec) { }

		public static double Area(List poly) { }

		private void BuildIntersectList(long topY) { }

		private void BuildResult(List polyg) { }

		private void BuildResult2(PolyTree polytree) { }

		public static List CleanPolygon(List path, double distance = 1.415) { }

		public static List CleanPolygons(List polys, double distance = 1.415) { }

		public static List ClosedPathsFromPolyTree(PolyTree polytree) { }

		private void CopyAELToSEL() { }

		private void DeleteFromSEL(TEdge e) { }

		private void DisposeAllPolyPts() { }

		private static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2) { }

		private static double DistanceSqrd(IntPoint pt1, IntPoint pt2) { }

		private void DoMaxima(TEdge e) { }

		private void DoSimplePolygons() { }

		private OutPt DupOutPt(OutPt outPt, bool InsertAfter) { }

		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) { }

		private bool EdgesAdjacent(IntersectNode inode) { }

		private static OutPt ExcludeOp(OutPt op) { }

		public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType) { }

		public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType FillType = 0) { }

		public bool Execute(ClipType clipType, List solution, PolyFillType subjFillType, PolyFillType clipFillType) { }

		public bool Execute(ClipType clipType, List solution, PolyFillType FillType = 0) { }

		private bool ExecuteInternal() { }

		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) { }

		internal void FixHoleLinkage(OutRec outRec) { }

		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) { }

		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec) { }

		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec) { }

		private bool FixupIntersectionOrder() { }

		private void FixupOutPolygon(OutRec outRec) { }

		private void FixupOutPolyline(OutRec outrec) { }

		[CompilerGenerated]
		public bool get_ReverseSolution() { }

		[CompilerGenerated]
		public bool get_StrictlySimple() { }

		private OutPt GetBottomPt(OutPt pp) { }

		private double GetDx(IntPoint pt1, IntPoint pt2) { }

		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right) { }

		private OutPt GetLastOutPt(TEdge e) { }

		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) { }

		internal TEdge GetMaximaPair(TEdge e) { }

		internal TEdge GetMaximaPairEx(TEdge e) { }

		private TEdge GetNextInAEL(TEdge e, Direction Direction) { }

		private OutRec GetOutRec(int idx) { }

		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) { }

		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b) { }

		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) { }

		private void InsertLocalMinimaIntoAEL(long botY) { }

		private void InsertMaxima(long X) { }

		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt) { }

		private static int IntersectNodeSort(IntersectNode node1, IntersectNode node2) { }

		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) { }

		private bool IsContributing(TEdge edge) { }

		private bool IsEvenOddAltFillType(TEdge edge) { }

		private bool IsEvenOddFillType(TEdge edge) { }

		private bool IsIntermediate(TEdge e, double Y) { }

		private bool IsMaxima(TEdge e, double Y) { }

		private bool IsMinima(TEdge e) { }

		private void JoinCommonEdges() { }

		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft) { }

		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2) { }

		internal static List Minkowski(List pattern, List path, bool IsSum, bool IsClosed) { }

		public static List MinkowskiDiff(List poly1, List poly2) { }

		public static List MinkowskiSum(List pattern, List path, bool pathIsClosed) { }

		public static List MinkowskiSum(List pattern, List paths, bool pathIsClosed) { }

		public static List OpenPathsFromPolyTree(PolyTree polytree) { }

		public static bool Orientation(List poly) { }

		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2) { }

		private static OutRec ParseFirstLeft(OutRec FirstLeft) { }

		private int PointCount(OutPt pts) { }

		public static int PointInPolygon(IntPoint pt, List path) { }

		private static int PointInPolygon(IntPoint pt, OutPt op) { }

		private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd) { }

		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2) { }

		public static List PolyTreeToPaths(PolyTree polytree) { }

		internal bool PopEdgeFromSEL(out TEdge e) { }

		private void ProcessEdgesAtTopOfScanbeam(long topY) { }

		private void ProcessHorizontal(TEdge horzEdge) { }

		private void ProcessHorizontals() { }

		private bool ProcessIntersections(long topY) { }

		private void ProcessIntersectList() { }

		public static void ReversePaths(List polys) { }

		private void ReversePolyPtLinks(OutPt pp) { }

		internal static long Round(double value) { }

		[CompilerGenerated]
		public void set_ReverseSolution(bool value) { }

		[CompilerGenerated]
		public void set_StrictlySimple(bool value) { }

		private void SetHoleState(TEdge e, OutRec outRec) { }

		private void SetWindingCount(TEdge edge) { }

		public static List SimplifyPolygon(List poly, PolyFillType fillType = 0) { }

		public static List SimplifyPolygons(List polys, PolyFillType fillType = 0) { }

		private static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd) { }

		internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2) { }

		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) { }

		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) { }

		private static void SwapSides(TEdge edge1, TEdge edge2) { }

		private static long TopX(TEdge edge, long currentY) { }

		private static List TranslatePath(List path, IntPoint delta) { }

		private void UpdateOutPtIdxs(OutRec outrec) { }

	}

	internal class ClipperBase
	{
		internal const double horizontal = -3.4E+38; //Field offset: 0x0
		internal const int Skip = -2; //Field offset: 0x0
		internal const int Unassigned = -1; //Field offset: 0x0
		internal const double tolerance = 1E-20; //Field offset: 0x0
		public const long loRange = 1073741823; //Field offset: 0x0
		public const long hiRange = 4611686018427387903; //Field offset: 0x0
		internal LocalMinima m_MinimaList; //Field offset: 0x10
		internal LocalMinima m_CurrentLM; //Field offset: 0x18
		internal List m_edges; //Field offset: 0x20
		internal Scanbeam m_Scanbeam; //Field offset: 0x28
		internal List m_PolyOuts; //Field offset: 0x30
		internal TEdge m_ActiveEdges; //Field offset: 0x38
		internal bool m_UseFullRange; //Field offset: 0x40
		internal bool m_HasOpenPaths; //Field offset: 0x41
		[CompilerGenerated]
		private bool <PreserveCollinear>k__BackingField; //Field offset: 0x42

		public bool PreserveCollinear
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		internal ClipperBase() { }

		public bool AddPath(List pg, PolyType polyType, bool Closed) { }

		public bool AddPaths(List ppg, PolyType polyType, bool closed) { }

		public override void Clear() { }

		internal OutRec CreateOutRec() { }

		internal void DeleteFromAEL(TEdge e) { }

		private void DisposeLocalMinimaList() { }

		internal void DisposeOutRec(int index) { }

		private TEdge FindNextLocMin(TEdge E) { }

		[CompilerGenerated]
		public bool get_PreserveCollinear() { }

		public static IntRect GetBounds(List paths) { }

		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) { }

		private void InitEdge2(TEdge e, PolyType polyType) { }

		private void InsertLocalMinima(LocalMinima newLm) { }

		internal void InsertScanbeam(long Y) { }

		internal static bool IsHorizontal(TEdge e) { }

		internal bool LocalMinimaPending() { }

		internal static bool near_zero(double val) { }

		internal bool PointIsVertex(IntPoint pt, OutPt pp) { }

		internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange) { }

		internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange) { }

		internal bool PopLocalMinima(long Y, out LocalMinima current) { }

		internal bool PopScanbeam(out long Y) { }

		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward) { }

		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) { }

		private void RangeTest(IntPoint Pt, ref bool useFullRange) { }

		private TEdge RemoveEdge(TEdge e) { }

		internal override void Reset() { }

		private void ReverseHorizontal(TEdge e) { }

		[CompilerGenerated]
		public void set_PreserveCollinear(bool value) { }

		private void SetDx(TEdge e) { }

		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) { }

		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) { }

		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange) { }

		public void Swap(ref long val1, ref long val2) { }

		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2) { }

		internal void UpdateEdgeIntoAEL(ref TEdge e) { }

	}

	private class ClipperException : Exception
	{

		public ClipperException(string description) { }

	}

	internal class ClipperOffset
	{
		private const double two_pi = 6.283185307179586; //Field offset: 0x0
		private const double def_arc_tolerance = 0.25; //Field offset: 0x0
		private List m_destPolys; //Field offset: 0x10
		private List m_srcPoly; //Field offset: 0x18
		private List m_destPoly; //Field offset: 0x20
		private List m_normals; //Field offset: 0x28
		private double m_delta; //Field offset: 0x30
		private double m_sinA; //Field offset: 0x38
		private double m_sin; //Field offset: 0x40
		private double m_cos; //Field offset: 0x48
		private double m_miterLim; //Field offset: 0x50
		private double m_StepsPerRad; //Field offset: 0x58
		private IntPoint m_lowest; //Field offset: 0x60
		private PolyNode m_polyNodes; //Field offset: 0x70
		[CompilerGenerated]
		private double <ArcTolerance>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private double <MiterLimit>k__BackingField; //Field offset: 0x80

		public double ArcTolerance
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public double MiterLimit
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public ClipperOffset(double miterLimit = 2, double arcTolerance = 0.25) { }

		public void AddPath(List path, JoinType joinType, EndType endType) { }

		public void AddPaths(List paths, JoinType joinType, EndType endType) { }

		public void Clear() { }

		internal void DoMiter(int j, int k, double r) { }

		private void DoOffset(double delta) { }

		internal void DoRound(int j, int k) { }

		internal void DoSquare(int j, int k) { }

		public void Execute(ref List solution, double delta) { }

		public void Execute(ref PolyTree solution, double delta) { }

		private void FixOrientations() { }

		[CompilerGenerated]
		public double get_ArcTolerance() { }

		[CompilerGenerated]
		public double get_MiterLimit() { }

		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) { }

		private void OffsetPoint(int j, ref int k, JoinType jointype) { }

		internal static long Round(double value) { }

		[CompilerGenerated]
		public void set_ArcTolerance(double value) { }

		[CompilerGenerated]
		public void set_MiterLimit(double value) { }

	}

	internal enum ClipType
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3,
	}

	public enum Direction
	{
		dRightToLeft = 0,
		dLeftToRight = 1,
	}

	internal struct DoublePoint
	{
		public double X; //Field offset: 0x0
		public double Y; //Field offset: 0x8

		public DoublePoint(double x = 0, double y = 0) { }

		public DoublePoint(DoublePoint dp) { }

		public DoublePoint(IntPoint ip) { }

	}

	public enum EdgeSide
	{
		esLeft = 0,
		esRight = 1,
	}

	internal enum EndType
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4,
	}

	public struct Int128
	{
		private long hi; //Field offset: 0x0
		private ulong lo; //Field offset: 0x8

		public Int128(long _lo) { }

		public Int128(long _hi, ulong _lo) { }

		public Int128(Int128 val) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public static Int128 Int128Mul(long lhs, long rhs) { }

		public bool IsNegative() { }

		public static Int128 op_Addition(Int128 lhs, Int128 rhs) { }

		public static bool op_Equality(Int128 val1, Int128 val2) { }

		public static double op_Explicit(Int128 val) { }

		public static bool op_GreaterThan(Int128 val1, Int128 val2) { }

		public static bool op_Inequality(Int128 val1, Int128 val2) { }

		public static bool op_LessThan(Int128 val1, Int128 val2) { }

		public static Int128 op_Subtraction(Int128 lhs, Int128 rhs) { }

		public static Int128 op_UnaryNegation(Int128 val) { }

	}

	internal class IntersectNode
	{
		internal TEdge Edge1; //Field offset: 0x10
		internal TEdge Edge2; //Field offset: 0x18
		internal IntPoint Pt; //Field offset: 0x20

		public IntersectNode() { }

	}

	internal struct IntPoint
	{
		public long X; //Field offset: 0x0
		public long Y; //Field offset: 0x8

		public IntPoint(long X, long Y) { }

		public IntPoint(double x, double y) { }

		public IntPoint(IntPoint pt) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(IntPoint a, IntPoint b) { }

		public static bool op_Inequality(IntPoint a, IntPoint b) { }

	}

	internal struct IntRect
	{
		public long left; //Field offset: 0x0
		public long top; //Field offset: 0x8
		public long right; //Field offset: 0x10
		public long bottom; //Field offset: 0x18

		public IntRect(long l, long t, long r, long b) { }

		public IntRect(IntRect ir) { }

	}

	public class Join
	{
		internal OutPt OutPt1; //Field offset: 0x10
		internal OutPt OutPt2; //Field offset: 0x18
		internal IntPoint OffPt; //Field offset: 0x20

		public Join() { }

	}

	internal enum JoinType
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2,
	}

	public class LocalMinima
	{
		internal long Y; //Field offset: 0x10
		internal TEdge LeftBound; //Field offset: 0x18
		internal TEdge RightBound; //Field offset: 0x20
		internal LocalMinima Next; //Field offset: 0x28

		public LocalMinima() { }

	}

	public class Maxima
	{
		internal long X; //Field offset: 0x10
		internal Maxima Next; //Field offset: 0x18
		internal Maxima Prev; //Field offset: 0x20

		public Maxima() { }

	}

	internal class MyIntersectNodeSort : IComparer
	{

		public MyIntersectNodeSort() { }

		public override int Compare(IntersectNode node1, IntersectNode node2) { }

	}

	public class OutPt
	{
		internal int Idx; //Field offset: 0x10
		internal IntPoint Pt; //Field offset: 0x18
		internal OutPt Next; //Field offset: 0x28
		internal OutPt Prev; //Field offset: 0x30

		public OutPt() { }

	}

	public class OutRec
	{
		internal int Idx; //Field offset: 0x10
		internal bool IsHole; //Field offset: 0x14
		internal bool IsOpen; //Field offset: 0x15
		internal OutRec FirstLeft; //Field offset: 0x18
		internal OutPt Pts; //Field offset: 0x20
		internal OutPt BottomPt; //Field offset: 0x28
		internal PolyNode PolyNode; //Field offset: 0x30

		public OutRec() { }

	}

	internal enum PolyFillType
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3,
	}

	internal class PolyNode
	{
		internal PolyNode m_Parent; //Field offset: 0x10
		internal List m_polygon; //Field offset: 0x18
		internal int m_Index; //Field offset: 0x20
		internal JoinType m_jointype; //Field offset: 0x24
		internal EndType m_endtype; //Field offset: 0x28
		internal List m_Childs; //Field offset: 0x30
		[CompilerGenerated]
		private bool <IsOpen>k__BackingField; //Field offset: 0x38

		public int ChildCount
		{
			 get { } //Length: 65
		}

		public List Childs
		{
			 get { } //Length: 76
		}

		public List Contour
		{
			 get { } //Length: 5
		}

		public bool IsHole
		{
			 get { } //Length: 28
		}

		public bool IsOpen
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public PolyNode Parent
		{
			 get { } //Length: 5
		}

		public PolyNode() { }

		internal void AddChild(PolyNode Child) { }

		public int get_ChildCount() { }

		public List get_Childs() { }

		public List get_Contour() { }

		public bool get_IsHole() { }

		[CompilerGenerated]
		public bool get_IsOpen() { }

		public PolyNode get_Parent() { }

		public PolyNode GetNext() { }

		internal PolyNode GetNextSiblingUp() { }

		private bool IsHoleNode() { }

		[CompilerGenerated]
		public void set_IsOpen(bool value) { }

	}

	internal class PolyTree : PolyNode
	{
		internal List m_AllPolys; //Field offset: 0x40

		public int Total
		{
			 get { } //Length: 167
		}

		public PolyTree() { }

		public void Clear() { }

		public int get_Total() { }

		public PolyNode GetFirst() { }

	}

	internal enum PolyType
	{
		ptSubject = 0,
		ptClip = 1,
	}

	public class Scanbeam
	{
		internal long Y; //Field offset: 0x10
		internal Scanbeam Next; //Field offset: 0x18

		public Scanbeam() { }

	}

	public class TEdge
	{
		internal IntPoint Bot; //Field offset: 0x10
		internal IntPoint Curr; //Field offset: 0x20
		internal IntPoint Top; //Field offset: 0x30
		internal IntPoint Delta; //Field offset: 0x40
		internal double Dx; //Field offset: 0x50
		internal PolyType PolyTyp; //Field offset: 0x58
		internal EdgeSide Side; //Field offset: 0x5C
		internal int WindDelta; //Field offset: 0x60
		internal int WindCnt; //Field offset: 0x64
		internal int WindCnt2; //Field offset: 0x68
		internal int OutIdx; //Field offset: 0x6C
		internal TEdge Next; //Field offset: 0x70
		internal TEdge Prev; //Field offset: 0x78
		internal TEdge NextInLML; //Field offset: 0x80
		internal TEdge NextInAEL; //Field offset: 0x88
		internal TEdge PrevInAEL; //Field offset: 0x90
		internal TEdge NextInSEL; //Field offset: 0x98
		internal TEdge PrevInSEL; //Field offset: 0xA0

		public TEdge() { }

	}


}

