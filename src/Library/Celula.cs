using System;
using System.Text;

namespace GameOfLife
{
    public static class Celula
    {
        public static bool[,] EstadoFromString(string data)
		{
			data = data.Replace("\r", "");
			string[] lines = data.Split('\n');
			int height = lines.Length;
			int width = lines[0].Length;

			bool[,] estado = new bool[width, height];

			for(int i = 0; i < width; i++)
			{
				for(int j = 0; j < height; j++)
				{
					char s = lines[j][i];
					switch (s)
					{
						case '0': estado[i, j] = false; break;
						case '1': estado[i, j] = true; break;
					}
				}
			}

			return estado;
		}

		public static string EstadoToString(bool[,] estado, string viva = "|X|", string muerta = null)
		{
			if(string.IsNullOrEmpty(viva))
				viva ??= "|X|";
			muerta ??= new String('-', viva.Length);
			StringBuilder sb = new StringBuilder("");
			for(int j = 0; j < estado.GetLength(1); j++)
			{
				for(int i = 0; i < estado.GetLength(0); i++)
				{
					sb.Append(estado[i, j] ? viva : muerta);
				}
				sb.Append("\n");
			}
			return sb.ToString();
		}

        public static bool Celulas_Vivas(bool celula_viva, byte vecino_vivo) => vecino_vivo == 3 | (celula_viva && vecino_vivo == 2);

    }
}
