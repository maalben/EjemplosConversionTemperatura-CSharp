using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemplosConversosTemperatura.clases
{
    public class Temperatura
    {
        //1. Atributos
        private double grados;

        //2. métodos setter y getter
        //setter: Entrega valor a / al atributo(s)
        public void setGrados(double valor)
        {
            this.grados = valor;
        }

        //getter: Consulta qué valor hay en el atributo
        public double getGrados()
        {
            return this.grados;
        }

        //3. Crear métodos de acción
        public double convertirAFahrenheit() {
            double total;
            total = (this.getGrados() * 9 / 5) + 32;
            return total;
        }

        public double convertirAKelvin() {
            double total;
            total = this.getGrados() + 273.15;
            return total;
        }

    }
}
