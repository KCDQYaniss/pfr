namespace CSML;

[DefaultMember("Item")]
public class Matrix
{
	internal enum DefinitenessType
	{
		PositiveDefinite = 0,
		PositiveSemidefinite = 1,
		NegativeDefinite = 2,
		NegativeSemidefinite = 3,
		Indefinite = 4,
	}

	private ArrayList Values; //Field offset: 0x10
	private int rowCount; //Field offset: 0x18
	private int columnCount; //Field offset: 0x1C

	public int ColumnCount
	{
		 get { } //Length: 4
	}

	public override Complex Item
	{
		 get { } //Length: 391
		 set { } //Length: 843
	}

	public override Complex Item
	{
		 get { } //Length: 590
		 set { } //Length: 1007
	}

	public int RowCount
	{
		 get { } //Length: 4
	}

	public Matrix(double x) { }

	public Matrix(string matrix_string) { }

	public Matrix() { }

	public Matrix(int m, int n) { }

	public Matrix(int n) { }

	public Matrix(Complex x) { }

	public Matrix(Complex[,] values) { }

	public Matrix(Complex[] values) { }

	public Matrix(double[,] values) { }

	public Matrix(double[] values) { }

	public double AbsColumnSum(int j) { }

	public double AbsRowSum(int i) { }

	public void BackwardInsertion(Matrix b) { }

	public static Matrix BFS(Matrix adjacence_matrix, int root) { }

	public static Matrix BlockMatrix(Matrix A, Matrix B, Matrix C, Matrix D) { }

	public static Matrix ChessboardMatrix(int m, int n, bool even) { }

	public static Matrix ChessboardMatrix(int n, bool even) { }

	public void Cholesky() { }

	public void CholeskyUndo() { }

	public Matrix Clone() { }

	public Matrix Column(int j) { }

	public Complex ColumnSum(int j) { }

	public double ColumnSumNorm() { }

	public Matrix[] ColumnVectorize() { }

	public double Condition(int p) { }

	public double Condition() { }

	public double ConditionFro() { }

	public Matrix ConjTranspose() { }

	public Matrix Conjugate() { }

	public DefinitenessType Definiteness() { }

	public void DeleteColumn(int j) { }

	public void DeleteRow(int i) { }

	public Complex Determinant() { }

	public static Matrix DFS(Matrix adjacence_matrix, int root) { }

	public static Matrix Diag(Matrix diag_vector, int offset) { }

	public static Matrix Diag(Matrix diag_vector) { }

	public Complex DiagProd() { }

	public Matrix DiagVector() { }

	public static Complex Dot(Matrix v, Matrix w) { }

	public static Matrix E(int n, int j) { }

	public Matrix Eigenvalues() { }

	public Matrix Eigenvector(Complex eigenvalue) { }

	public virtual bool Equals(object obj) { }

	public Matrix Extract(int i1, int i2, int j1, int j2) { }

	public Matrix ExtractColumn(int j) { }

	public Matrix ExtractLowerTrapeze() { }

	public Matrix ExtractRow(int i) { }

	public Matrix ExtractUpperTrapeze() { }

	public static Matrix Eye(int n) { }

	private double Factorial(int x) { }

	public static Complex Fib(int n) { }

	public static Matrix[] Floyd(Matrix adjacence_matrix) { }

	public static ArrayList FloydPath(Matrix P, int i, int j) { }

	public void ForwardInsertion(Matrix b) { }

	public double FrobeniusNorm() { }

	public void Gacol(Complex c, Complex s, int j1, int j2, int i, int k) { }

	private void Garow(Complex c, Complex s, int i, int k, int j1, int j2) { }

	public int get_ColumnCount() { }

	public override Complex get_Item(int i, int j) { }

	public override Complex get_Item(int i) { }

	public int get_RowCount() { }

	public virtual int GetHashCode() { }

	public int GetMinColumn() { }

	public int GetMinRow() { }

	private Complex[] GivensCS(Complex xi, Complex xk) { }

	private Matrix GivProd(Matrix c, Matrix s, int n) { }

	public bool HasZeroRowOrColumn() { }

	public Matrix[] HessenbergHouseholder() { }

	public static Matrix HorizontalConcat(Matrix A, Matrix B) { }

	public static Matrix HorizontalConcat(Matrix[] A) { }

	public void HorizontalFlip() { }

	private static Matrix[] HouseholderVector(Matrix x) { }

	public static Matrix Identity(int n) { }

	public Matrix Im() { }

	public void Insert(int i, int j, Matrix M) { }

	public void InsertColumn(Matrix col, int j) { }

	public void InsertRow(Matrix row, int i) { }

	public Matrix Inverse() { }

	public Matrix InverseLeverrier() { }

	public bool IsDiagonal() { }

	public bool IsHermitian() { }

	public bool IsInvolutary() { }

	public bool IsLowerTrapeze() { }

	public bool IsLowerTriangular() { }

	public bool IsNormal() { }

	public bool IsOrthogonal() { }

	public bool IsPermutation() { }

	public bool IsReal() { }

	public bool IsSPD() { }

	public bool IsSquare() { }

	public bool IsSymmetric() { }

	public bool IsSymmetricPositiveDefinite() { }

	public bool IsTrapeze() { }

	public bool IsTriangular() { }

	public bool IsUnitary() { }

	public bool IsUpperTrapeze() { }

	public bool IsUpperTriangular() { }

	public bool IsZeroOneMatrix() { }

	public static Complex KroneckerDelta(int i, int j) { }

	public void LU() { }

	public Matrix LUSafe() { }

	public double MaxNorm() { }

	public Matrix Minor(int i, int j) { }

	public double Norm() { }

	public static Matrix Ones(int m, int n) { }

	public static Matrix Ones(int n) { }

	public static Matrix op_Addition(Matrix A, Matrix B) { }

	public static Matrix op_Division(Matrix A, double x) { }

	public static Matrix op_Division(Matrix A, Complex x) { }

	public static bool op_Equality(Matrix A, Matrix B) { }

	public static Matrix op_ExclusiveOr(Matrix A, int k) { }

	public static bool op_Inequality(Matrix A, Matrix B) { }

	public static Matrix op_Multiply(Matrix A, Matrix B) { }

	public static Matrix op_Multiply(double x, Matrix A) { }

	public static Matrix op_Multiply(Matrix A, Complex x) { }

	public static Matrix op_Multiply(Complex x, Matrix A) { }

	public static Matrix op_Multiply(Matrix A, double x) { }

	public static Matrix op_Subtraction(Matrix A, Matrix B) { }

	public static Matrix op_UnaryNegation(Matrix A) { }

	public Complex Permanent() { }

	public double PNorm(double p) { }

	public Matrix[] QRGivens() { }

	public Matrix[] QRGramSchmidt() { }

	public Matrix QRIterationBasic(int max_iterations) { }

	public Matrix QRIterationHessenberg(int max_iterations) { }

	public static Matrix Random(int m, int n) { }

	public static Matrix Random(int n) { }

	public static Matrix Random(int n, int lo, int hi) { }

	public static Matrix Random(int m, int n, int lo, int hi) { }

	public static Matrix RandomGraph(int n) { }

	public static Matrix RandomGraph(int n, double p) { }

	public static Matrix RandomZeroOne(int n, double p) { }

	public static Matrix RandomZeroOne(int m, int n, double p) { }

	public Matrix Re() { }

	public Matrix Row(int i) { }

	public Complex RowSum(int i) { }

	public double RowSumNorm() { }

	public Matrix[] RowVectorize() { }

	public override void set_Item(int i, Complex value) { }

	public override void set_Item(int i, int j, Complex value) { }

	public double Signum() { }

	public static Matrix Solve(Matrix A, Matrix b) { }

	public Matrix SolveCG(Matrix b) { }

	private Complex Sqr(Complex x) { }

	public void SwapColumns(int j1, int j2) { }

	public void SwapRows(int i1, int i2) { }

	public void SymmetrizeDown() { }

	public void SymmetrizeUp() { }

	public double TaxiNorm() { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public Complex Trace() { }

	public Matrix Transpose() { }

	public static Matrix TriDiag(Complex l, Complex d, Complex u, int n) { }

	public static Matrix TriDiag(Matrix l, Matrix d, Matrix u) { }

	public static Matrix Vandermonde(Complex[] x) { }

	public int VectorLength() { }

	public static Matrix VerticalConcat(Matrix[] A) { }

	public static Matrix VerticalConcat(Matrix A, Matrix B) { }

	public void VerticalFlip() { }

	public static Matrix ZeroOneRandom(int n, double p) { }

	public static Matrix ZeroOneRandom(int m, int n, double p) { }

	public static Matrix Zeros(int n) { }

	public static Matrix Zeros(int m, int n) { }

}

