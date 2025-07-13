using System;
using System.Collections.Generic;

namespace MyCompiler
{
    internal class Sintactico
    {
        public List<string> Errors;

        public bool Analizar(List<Simbolo> ts)
        {
            Errors = new List<string>();

            int index = 0;
            bool valido = Expresion(ts, ref index);

            if (!valido || ts[index].Token != "EOF")
            {
                Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Expresión incompleta o mal formada. Se encontró '{ts[index].Lexema}'");
                return false;
            }

            return true;
        }

        private bool Expresion(List<Simbolo> ts, ref int index)
        {
            if (!TerminoSumaResta(ts, ref index)) return false;

            while (ts[index].Lexema == "+" || ts[index].Lexema == "-")
            {
                index++;
                if (!TerminoSumaResta(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba término después del operador '+' o '-'.");
                    return false;
                }
            }

            return true;
        }

        private bool TerminoSumaResta(List<Simbolo> ts, ref int index)
        {
            if (!TerminoMultiplicacionDivisionModulo(ts, ref index)) return false;

            while (ts[index].Lexema == "+" || ts[index].Lexema == "-")
            {
                index++;
                if (!TerminoMultiplicacionDivisionModulo(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba término después del operador '+' o '-'.");
                    return false;
                }
            }
            return true;
        }

        private bool TerminoMultiplicacionDivisionModulo(List<Simbolo> ts, ref int index)
        {
            if (!TerminoPotencia(ts, ref index)) return false;

            while (ts[index].Lexema == "*" || ts[index].Lexema == "/" || ts[index].Lexema == "%")
            {
                index++;
                if (!TerminoPotencia(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba factor después del operador '*' '/' o '%'.");
                    return false;
                }
            }
            return true;
        }

        private bool TerminoPotencia(List<Simbolo> ts, ref int index)
        {
            if (!Unario(ts, ref index)) return false;

            if (ts[index].Lexema == "^")
            {
                index++;
                if (!TerminoPotencia(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba operando después del operador '^'.");
                    return false;
                }
            }
            return true;
        }

        private bool Unario(List<Simbolo> ts, ref int index)
        {
            string lexema = ts[index].Lexema;
            if (lexema == "+" || lexema == "-")
            {
                index++;
                if (!Factorial(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba una expresión después del operador unario '{lexema}'.");
                    return false;
                }
                return true;
            }
            return Factorial(ts, ref index);
        }

        private bool Factorial(List<Simbolo> ts, ref int intialIndex)
        {
            int index = intialIndex;
            if (!Primario(ts, ref index)) return false;

            if (ts[index].Lexema == "!")
            {
                intialIndex = index + 1;
                return true;
            }

            intialIndex = index;
            return true;
        }

        private bool Primario(List<Simbolo> ts, ref int index)
        {
            string token = ts[index].Token;
            string lexema = ts[index].Lexema;

            if (token == "Entero" || token == "Real")
            {
                index++;
                return true;
            }

            if (token == "Constante")
            {
                index++;
                return true;
            }

            if (lexema == "(")
            {
                index++;
                if (!Expresion(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Expresión inválida dentro de paréntesis.");
                    return false;
                }

                if (ts[index].Lexema == ")")
                {
                    index++;
                    return true;
                }
                else
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba ')' para cerrar el paréntesis.");
                    return false;
                }
            }

            if (token == "Funcion")
            {
                index++;
                if (ts[index].Lexema != "(")
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba '(' después de función '{lexema}'.");
                    return false;
                }

                index++;
                if (!Expresion(ts, ref index))
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Expresión inválida como argumento de función '{lexema}'.");
                    return false;
                }

                if (ts[index].Lexema == ")")
                {
                    index++;
                    return true;
                }
                else
                {
                    Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba ')' al final de la función '{lexema}'.");
                    return false;
                }
            }

            Errors.Add($"Error ({ts[index].Linea},{ts[index].Columna}): Se esperaba número, constante, función o paréntesis de apertura. Se encontró '{ts[index].Lexema}' ({ts[index].Token}).");
            return false;
        }
    }
}