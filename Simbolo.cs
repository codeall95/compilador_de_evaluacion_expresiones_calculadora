using System;

namespace MyCompiler
{
    /// <summary>
    /// Representa un símbolo léxico con información del lexema, su tipo (token), y su posición (línea y columna).
    /// </summary>
    internal class Simbolo // 👈 Se mantiene como internal, como tú pediste
    {
        /// <summary>
        /// El texto original encontrado (por ejemplo: "3", "+", "sen", "(", etc.)
        /// </summary>
        public string Lexema { get; set; }

        /// <summary>
        /// El tipo de token reconocido (por ejemplo: Entero, Real, Operador, ParenAbre, Funcion, etc.)
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Línea del texto donde aparece este símbolo.
        /// </summary>
        public int Linea { get; set; }

        /// <summary>
        /// Columna del texto donde aparece este símbolo.
        /// </summary>
        public int Columna { get; set; }
    }
}
