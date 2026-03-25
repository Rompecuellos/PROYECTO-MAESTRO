using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAESTRO
{
    public partial class Form2 : Form
    {
        public int puntaje { get; set; } = 0; // Se creo una variable publica para poder llamarla desde otro formulario
        int indicePregunta = 0; // Nos ayuda a controlar en qué pregunta vas
        List<Pregunta> bancoPreguntas = new List<Pregunta>(); // Se creo una lista donde guardamos todas las preguntas
        Random rnd = new Random(); // Se utiliza la clase ramdom para mezclar las preguntas

        void MostrarPregunta()
        {
            // Muestra el número de pregunta actual
            lblNumeroPregunta.Text = "Pregunta " + (indicePregunta + 1) + " de 10";
            var p = bancoPreguntas[indicePregunta]; // Obtiene la pregunta actual

            lblP1.Text = p.Texto;
            // Asigna cada opción a su botón
            btnAP1.Text = p.Opciones[0];
            btnBP1.Text = p.Opciones[1];
            btnCP1.Text = p.Opciones[2];
            btnDP1.Text = p.Opciones[3];

        }
        void VerificarRespuesta(int opcionSeleccionada)
        {
            var p = bancoPreguntas[indicePregunta];

            if (opcionSeleccionada == p.Correcta)
            {
                puntaje++; // Suma punto si es correcta
                MessageBox.Show("¡Correcto!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string correctaTexto = p.Opciones[p.Correcta]; // Muestra cuál era la respuesta correcta
                MessageBox.Show("Incorrecto ;(.\nLa respuesta correcta es: " + correctaTexto,"", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            indicePregunta++;
            // Avanza a la siguiente pregunta
            if (indicePregunta < bancoPreguntas.Count)
            {
                MostrarPregunta();  // Muestra la siguiente
            }
            else
            {
                // Si ya no hay más preguntas, abre el siguiente formulario
                Form3 llamar = new Form3(this);
                llamar.Show();
                this.Hide(); 
            }
        }
        class Pregunta
        {
            public string Texto; // Texto de la pregunta    
            public string[] Opciones; // Opciones de respuesta
            public int Correcta; // Índice de la respuesta correcta
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Aquí agregamos todas las preguntas manualmente
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es una matriz en álgebra lineal?",
                Opciones = new string[] { "Un número", "Un arreglo de números", "Una función", "Un vector" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué unidad mide la corriente eléctrica?",
                Opciones = new string[] { "Voltios", "Ohmios", "Amperios", "Watts" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "Si lanzas una moneda equilibrada, \n¿cuál es la probabilidad de obtener cara?",
                Opciones = new string[] { "1", "1/2", "1/3", "2" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuál es el propósito principal de \nuna integral definida?",
                Opciones = new string[] { "Calcular la pendiente de una función", "Encontrar raíces cuadradas", "Resolver ecuaciones lineales", "Encontrar el área bajo una curva en un intervalo" },
                Correcta = 3
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué representa el determinante\n de una matriz?",
                Opciones = new string[] { "La suma de sus elementos", "El número de colmunas", "El número de filas", "Un valor que la matriz indica si tiene inversa" },
                Correcta = 3
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuándo una matriz tiene \ninversa?",
                Opciones = new string[] { "Cuando su determinante es 0", "Cuando es cuadrada y su determinante ≠ 0", "Siempre", "Cuando tiene más filas que columnas" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es un vector?",
                Opciones = new string[] { "Un número entero", "Una matriz cuadrada", "Un arreglo de elementos con magnitud y dirección", "Una función" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué operación combina filas de \nmatrices?",
                Opciones = new string[] { "Multiplicación escalar", "Suma de matrices", "Producto cruz", "Derivación" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué significa que dos vectores \nsean ortogonales?",
                Opciones = new string[] { "Que son iguales", "Que tienen la misma magnitud", "Que son paralelos", "Que su producto punto es 0" },
                Correcta = 3
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué ley relaciona voltaje, \ncorriente y resistencia?",
                Opciones = new string[] { "Ley de Faraday", "Ley de Coulomb", "Ley de Ohm", "Ley de Gauss" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuál es la unidad de resistencia \neléctrica?",
                Opciones = new string[] { "Voltio", "Ampere", "Ohm", "Watt" },
                Correcta = 3
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué mide el voltaje?",
                Opciones = new string[] { "Potencia", "Resistencia", "Diferencia de potencial eléctrico", "Corriente" },
                Correcta = 0
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué partícula tiene carga negativa?",
                Opciones = new string[] { "Protón", "Electrón", "Neutrón", "Fotón" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué dispositivo almacena \nenergía eléctrica?",
                Opciones = new string[] { "Resistor", "Capacitor", "Inductor", "Diodo" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué mide la media?",
                Opciones = new string[] { "El valor más frecuente", "El valor central", "El promedio de un conjunto de datos", "La dispersión" },
                Correcta = 2
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es la varianza?",
                Opciones = new string[] { "Un promedio", "Una medida de dispersión", "Un valor máximo", "Una probabilidad" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué distribución es continua?",
                Opciones = new string[] { "Binomial", "Poisson", "Normal", "Geométrica" },
                Correcta = 2
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué valor toma la \nprobabilidad máxima?",
                Opciones = new string[] { "0", "1", "10", "-1" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué representa la mediana?",
                Opciones = new string[] { "El promedio", "El valor central ordenado", "El valor mayor", "El valor menor" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuál es la integral de 1 dx?",
                Opciones = new string[] { "x", "1", "0", "x²" },
                Correcta = 0
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es una integral indefinida?",
                Opciones = new string[] { "Un número", "Una función con constante de integración", "Un límite", "Un vector" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué símbolo representa una integral?",
                Opciones = new string[] { "∑", "∫", "√", "Δ" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué técnica se usa cuando \nhay productos de funciones?",
                Opciones = new string[] { "Sustitución", "Integración por partes", "Derivación", "Factorización" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿La integral es el proceso \ninverso de qué?",
                Opciones = new string[] { "Suma", "Multiplicación", "Derivación", "División" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es una variable?",
                Opciones = new string[] { "Un ciclo", "Un espacio para almacenar datos", "Un programa", "Un error" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué estructura se usa \npara tomar decisiones?",
                Opciones = new string[] { "For", "While", "If", "Switch" },
                Correcta = 2
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué tipo de dato almacena texto?",
                Opciones = new string[] { "int", "float", "string", "bool" },
                Correcta = 2
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué hace un ciclo while?",
                Opciones = new string[] { "Ejecuta una vez", "Ejecuta mientras se cumpla una condición", "Nunca ejecuta", "Solo imprime datos" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es un algoritmo?",
                Opciones = new string[] { "Un error de código", "Un conjunto de pasos para resolver un problema", "Un lenguaje de programación", "Un compilador" },
                Correcta = 1
            });
            // Este OberBy mezcla las preguntas y toma solo 10
            bancoPreguntas = bancoPreguntas.OrderBy(x => rnd.Next()).Take(10).ToList();
            MostrarPregunta(); // Inicia mostrando la primera pregunta
        }

        private void btnAP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(0);
        }

        private void btnBP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(1);
        }

        private void btnCP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(2);
        }

        private void btnDP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(3);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Regresa al formulario de inicio
            Form1 llamar = new Form1();
            llamar.Show();
            this.Hide();
        }
    }
}
