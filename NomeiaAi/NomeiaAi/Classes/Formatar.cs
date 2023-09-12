using System.Globalization;
using System.Text;

namespace NomeiaAi.Classes
{
    public class Formatar
    {
        public static string RemoverAcentosEspacosPreposicoes(string input)
        {
            // Remove acentos da frase
            string fraseSemAcentos = RemoverAcentos(input);

            // Divide a frase em palavras
            string[] palavras = fraseSemAcentos.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string[] AjustePalavras = new string[palavras.Length];
            for (int i = 0; i < palavras.Length; i++)
            {
                AjustePalavras[i] = CapitalizarPrimeiraLetra(palavras[i]);
            }

            // Lista de preposições em português (você pode adicionar mais preposições, se necessário)
            string[] preposicoes = { "a", "e", "i", "o", "u", "ante", "apos", "ate", "com", "contra", "da", "de", "di", "do", "du", "desde", "em", "entre", "para", "perante", "por", "sem", "sob", "sobre", "tras", "gerenciar", "cadastro" };

            // Filtra as palavras, removendo preposições
            var palavrasFiltradas = Array.FindAll(AjustePalavras, palavra => !preposicoes.Contains(palavra.ToLower()));

            // Une as palavras novamente em uma única string
            string resultado = string.Join(" ", palavrasFiltradas);

            return resultado.Replace(" ", "");
        }
        public static string RemoverAcentos(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }
        public static string CapitalizarPrimeiraLetra(string palavra)
        {
            if (string.IsNullOrEmpty(palavra))
            {
                return palavra; // Retorna a palavra original se for vazia ou nula
            }

            // Converte a primeira letra para maiúscula e mantém o restante da palavra em minúsculas
            return palavra[0].ToString().ToUpper() + palavra[1..];
        }
    }
}
