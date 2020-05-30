using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    class mas
    {
		int[,] IntArray;
		int n, m;
		public mas() { }
		public mas(int N, int M)
		{
			if (N > 0 && M > 0)
			{
				n = N;
				m = M;
				IntArray = new int[n, m];
			}
			else throw new Exception("Некорректный размер массива");
		}
		public int yong
		{
			get
			{
				int zero = 0;
				for (int i = 0; i < IntArray.GetLength(0); i++)
				{
					for (int j = 0; j < IntArray.GetLength(1); j++)
					{
						if (IntArray[i, j] == 0)
							zero++;
					}
				}
				return zero;
			}
		}

		public int Scalar
		{
			set
			{
				if (n == m)
				{
					for (int i = 0; i < IntArray.GetLength(0); i++)
					{
						IntArray[i, i] = value;
					}
				}
				else throw new Exception("Массив не  квадратный!");
			}
		}
		public void random_array()
		{
			Random rand = new Random();
			for (int i = 0; i < n; i++)
				for (int j = 0; j < m; j++)
					IntArray[i, j] = rand.Next(-5, 10);
		}

		public void Output(DataGridView tabel)
		{
			tabel.RowCount = n;
			tabel.ColumnCount = m;
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < m; ++j)
				{
					tabel.Columns[j].Width = 25;
					tabel.Rows[i].Cells[j].Value = IntArray[i, j];
				}

			}

		}

		public int summ(int m)
		{
			int sum = 0;
			for (int i = 0; i < n; i++)
				sum += IntArray[i, m];
			return sum;
		}

		public int this[int i, int j]
		{
			get
			{
				if (i < 0 || i > IntArray.GetLength(0) - 1 && j < 0 || j > IntArray.GetLength(1) - 1)
				{
					throw new Exception("Элемента с таким индексом нет.");
				}
				return IntArray[i, j];
			}
			set
			{
				if (i < 0 || i > IntArray.GetLength(0) - 1 && j < 0 || j > IntArray.GetLength(1) - 1)
				{
					throw new Exception("Элемента с таким индексом нет.");
				}
				IntArray[i, j] = value;
			}
		}


		public static explicit operator int[,](mas p)
		{
			return p.IntArray;
		}

		public static implicit operator mas(int[,] array)
		{
			mas result = new mas();
			result.n = array.GetLength(0);
			result.m = array.GetLength(1);
			result.IntArray = array;
			return result;
		}
		public static mas operator ++(mas increment)
		{
			for (int i = 0; i < increment.IntArray.GetLength(0); i++)
			{
				for (int j = 0; j < increment.IntArray.GetLength(1); j++)
					increment.IntArray[i, j] += 1;
			}
			return increment;
		}
		public static mas operator --(mas decrement)
		{
			for (int i = 0; i < decrement.IntArray.GetLength(0); i++)
			{
				for (int j = 0; j < decrement.IntArray.GetLength(1); j++)
					decrement.IntArray[i, j] -= 1;
			}
			return decrement;
		}


		public static mas operator +(mas a, mas b)
		{
			if (a.n == b.n && a.m == b.m)
			{
				mas rez = new mas(a.n, b.m);
				for (int i = 0; i < rez.n; i++)
					for (int j = 0; j < rez.m; j++)
					{
						rez[i, j] = a[i, j] + b[i, j];
					}
				return rez;
			}
			else
			{
				throw new Exception("Массивы имеют разные размеры!");
			}
		}

		public static bool operator true(mas q)
		{
			int n = q.IntArray.GetLength(0);
			int m = q.IntArray.GetLength(1);
			if (n == m) return true;
			else return false;
		}
		public static bool operator false(mas q)
		{
			int n = q.IntArray.GetLength(0);
			int m = q.IntArray.GetLength(1);
			if (n != m) return false;
			else return true;
		}
	}
}
