using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer23_Busqueda_Binaria_Vector
{
    class Vector
    {
        public int []vector;
        public int comparaciones { get; private set; }

        public void crearVector(int tamaño)
        {
            vector = new int[tamaño];
        }

        static Random aleatorio = new Random(DateTime.Now.Millisecond);
        public void llenarVector(int limite)
        {
            for(int contador=0;contador<vector.Length;contador++)
                vector[contador]=aleatorio.Next(0, limite+1);
         }

        public void ordenarVector()
        {
            Array.Sort(vector);
        }

        public string mostrar()
        {
            string registro="";
            for (int contador = 0; contador < vector.Length-1; contador++)
                registro+=vector[contador].ToString()+Environment.NewLine;
            registro += vector[vector.Length - 1];
            return registro;
        }

        public int busquedaBinaria(int numero)
        {
            int limiteInferior = 0;
            int limiteSuperior = vector.Length - 1;
            comparaciones = 0;

            comparaciones++;
            if (vector[limiteInferior] > numero)
                return -1;
            else {
                comparaciones++;
                if (vector[limiteSuperior] < numero)
                    return -1;
                else {
                    comparaciones++;
                    if (vector.Length == 1){
                        if (vector[0] == numero)
                            return 0;
                        else
                            return -1;
                    }
                    else
                        return busquedaBinaria(limiteInferior, limiteSuperior, numero);
                }
            }     
        }

        private string ultimoMovimiento;
        private int busquedaBinaria(int limiteInferior, int limiteSuperior, int numero) {
            int mitad=0;

            if ((limiteSuperior - limiteInferior) >= 1)
                mitad = ((limiteSuperior - limiteInferior) / 2 + limiteInferior);
            else
                return -1;               

            if (limiteSuperior - limiteInferior == 1) {
                if (ultimoMovimiento == "LS")
                    mitad = limiteInferior;
                else
                    mitad = limiteSuperior;

                comparaciones++;
                if (vector[mitad] == numero)
                    return mitad;
                else
                    return -1;
            }

            int datoVector = vector[mitad];
            comparaciones++;
            if (datoVector == numero)
                return mitad;
            else{
                if (datoVector < numero){
                    limiteInferior = mitad;
                    ultimoMovimiento = "LI";
                }
                else {
                    limiteSuperior = mitad;
                    ultimoMovimiento = "LS";
                }
                return busquedaBinaria(limiteInferior, limiteSuperior, numero);
            }
        }
    }
}
