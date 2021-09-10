using System;
<<<<<<< HEAD
using System.Text;

namespace GameOfLife
{
    public class GameOfLife
	{
		public bool[,] Estado { get; private set; }
		public int Width { get => Estado.GetLength(0); }
		public int Height { get => Estado.GetLength(1); }

		public GameOfLife(bool[,] estado)
		{
			this.Estado = estado;
		}

		public void Tablero()
		{
			bool[,] celulas = new bool[this.Width, this.Height];

			for(int i = 0; i < this.Width; i++)
				for(int j = 0; j < this.Height; j++)
				{
					byte vecino_vivo = 0;
					for(int k = i - 1; k <= i + 1; k++)
						for(int l = j - 1; l <= j + 1; l++)
							if (
								k >= 0 && l >= 0
								&& k < this.Width
								&& l < this.Height
								&& this.Estado[k, l]
							) vecino_vivo++;

					if (this.Estado[i, j]) vecino_vivo--;

					celulas[i, j] = Celula.Celulas_Vivas(this.Estado[i, j], vecino_vivo);
				}
				
			this.Estado = celulas;
		}
    }
}

