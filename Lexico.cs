using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyCompiler
{
    internal class Lexico
    {
        public List<string> Errors { get; private set; } = new List<string>();

        private readonly Dictionary<string, string> _regexPatterns;
        private readonly HashSet<string> _funciones;
        private readonly HashSet<string> _constantes;

        public Lexico()
        {
            _funciones = new HashSet<string>
            {
                "sen", "cos", "tan", "log10", "ln", "abs", "csc", "sec", "cotan"
            };

            _constantes = new HashSet<string>
            {
                "pi", "e"
            };

            _regexPatterns = new Dictionary<string, string>
            {
                {"Real", @"\d+\.\d+"},
                {"Entero", @"\d+"},
                {"Funcion", @"(?:" + string.Join("|", _funciones.Select(f => Regex.Escape(f))) + @")"},
                {"Constante", @"(?:" + string.Join("|", _constantes.Select(c => Regex.Escape(c))) + @")"},
                {"Operador", @"[+\-*/^%!]"},
                {"ParenAbre", @"\("},
                {"ParenCierre", @"\)"},
                {"PuntoDecimal", @"\."},
                {"EspacioBlanco", @"\s+"},
                {"CaracterNoValido", @"."}
            };
        }

        public List<Simbolo> Analizar(string input)
        {
            Errors.Clear();
            List<Simbolo> simbolos = new List<Simbolo>();
            int linea = 1;
            int columna = 1;
            int i = 0;

            string combinedPattern = string.Join("|", _regexPatterns.Select(kvp => $"(?<{kvp.Key}>{kvp.Value})"));
            Regex regex = new Regex(combinedPattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);

            while (i < input.Length)
            {
                Match match = regex.Match(input, i);

                if (match.Success && match.Index == i)
                {
                    string lexema = match.Value;
                    string tokenType = null;

                    foreach (var kvp in _regexPatterns)
                    {
                        if (match.Groups[kvp.Key].Success)
                        {
                            tokenType = kvp.Key;
                            break;
                        }
                    }

                    if (tokenType == "EspacioBlanco")
                    {
                        columna += lexema.Length;
                        i += lexema.Length;
                        continue;
                    }

                    // Para CaracterNoValido y otros tokens, ahora siempre añadimos a la lista de símbolos
                    simbolos.Add(new Simbolo
                    {
                        Lexema = lexema,
                        Token = tokenType,
                        Linea = linea,
                        Columna = columna
                    });

                    // Si es un CaracterNoValido, también lo añadimos a la lista de errores
                    if (tokenType == "CaracterNoValido")
                    {
                        Errors.Add($"Error léxico ({linea},{columna}): Carácter no válido '{lexema}'");
                    }

                    columna += lexema.Length;
                    i += lexema.Length;
                }
                else
                {
                    Errors.Add($"Error léxico ({linea},{columna}): Secuencia no reconocida '{input[i]}'");
                    columna++;
                    i++;
                }
            }

            simbolos.Add(new Simbolo
            {
                Lexema = "#",
                Token = "EOF",
                Linea = linea,
                Columna = columna
            });

            return simbolos;
        }
    }
}