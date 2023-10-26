using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fronttback
{
    public class Volumen
    {
        //-Programa que permita Calcular el volumen de una esfera, de un cubo y de un cilindro-
        private float radio;
        private float lado;
        private float altura;
        private float pi = 3.14f;

        public float Radio { get; set; }
        public float Lado { get; set; }
        public float Altura { get; set; }
        public float Pi { get; set; }

        public  float volEsfera(float pi, float radio)
        {
            float volumenEs = 0f;

            volumenEs = ((float)(1.33f * pi * Math.Pow(radio, 3)));

            return volumenEs;
        }
        
        public float volCubo(float lado)
        {
            float volumenCub = 0f;

            volumenCub = lado * lado * lado;

            return volumenCub;
        }

        public float volCilindro(float pi, float radio, float altura)
        {
            float volumenCil = 0f;

            volumenCil = pi * radio * radio * altura;

            return volumenCil;
        }
    }
}
