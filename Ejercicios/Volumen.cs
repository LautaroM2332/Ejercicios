using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Volumen
    {
        //-Programa que permita Calcular el volumen de una esfera, de un cubo y de un cilindro-
        public int radio { get; set; }
        public int lado { get; set; }
        public int altura { get; set; }
        public double pi = 3.14;

        
        public double volEsfera(int radio, double pi)
        {
            double volumenEs = 0;

            volumenEs = (1.33 * pi * radio * radio * radio);

            return volumenEs;
        }

        public int volCubo(int lado)
        {
            int volumenCub = 0;

            volumenCub = lado * lado * lado;

            return volumenCub;
        }

        public double volCilindro(int radio, int altura, double pi)
        {
            double volumenCil = 0;

            volumenCil = pi * radio * radio * altura;

            return volumenCil;
        }
    }
}

