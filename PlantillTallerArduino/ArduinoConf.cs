using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace PlantillTallerArduino
{
    class ArduinoConf
    {
        /// <summary>
        ///    Obtiene el puerto al que está conectado Arduino, si hay más de 1 puerto o ninguno devuelve el valor 'not found'
        /// </summary>
        public string portName
        {
            get
            {
                return getPort();
            }
        }
        /// <summary>
        ///     Obtiene el valor de la frecuencia de unidades por segundo 
        /// </summary>
        public int baudRate { get; }

        /// <summary>
        /// Crea una instancia para administrar la configuración a Arduino
        /// </summary>
        /// <param name="baudRate">(int)Establece la frecuencia de unidades por segundo</param>
        public ArduinoConf(int baudRate)
        {
            this.baudRate = baudRate;
        }

        string getPort()
        {
            var ports = SerialPort.GetPortNames();

            if (ports.Length==1)
            {
                return ports[0];
            }
            else
            {
                return "not found";
            }

        }
        /// <summary>
        /// Regresa una instancia de SerialPort configurada
        /// </summary>
        public SerialPort getSerialPort()
        {
            return new SerialPort() {
                PortName=this.portName,
                BaudRate=this.baudRate
            };
        }

    }
}
