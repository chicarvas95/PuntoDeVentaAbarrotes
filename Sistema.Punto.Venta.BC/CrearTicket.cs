using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace Sistema.Punto.Venta.BC
{
    public class CrearTicket
    {
        //Creamos un objeto de la clase StringBuilder, en este objeto agregamos las lineas del ticket
        StringBuilder linea = new StringBuilder();
        //Creamos una variable para almacenar el numero maximo de caracteres que permitiremos en el ticket.
        int maxCar = 40, cortar;

        //creamos el primer metodo, este dibujara lineas guion
       public string lineasGuio()
        {
            string lineasGuion = "";
            for(int i = 0; i< maxCar; i++)
            {
                lineasGuion += "-";
            }

            return linea.AppendLine(lineasGuion).ToString();
        }
        
        //Metodo para dibujar una linea con asteriscos
        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for(int i = 0; i< maxCar; i++)
            {
                lineasAsterisco = "*";//Agregara un asterisco hasta llegar al numero maximo de caracteres.
            }
            return linea.AppendLine(lineasAsterisco).ToString();
        }

        //Realizamos el mismo procedimiento para dibujar una linea con el signo igual
        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual = "=";//Agregara un igual hasta llegar al numero maximo de caracteres.
            }
            return linea.AppendLine(lineasIgual).ToString();
        }

        //Creamos el encabezado para los articulos
        public void EncabezadoVenta()
        {
            linea.AppendLine("ARTICULO     |CANT|PRECIO|IMPORTE");//Escribimos los espacios para mostrar el articulo. En total tienen que ser 40 caracteres.
        }

        //Creamos un metodo para poner el texto a la izquierda
        public void TextoIzquierda(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Si no es mayor solo agregarlo
                linea.AppendLine(texto);
            }
        }

        //Creamos un metodo para poner el texto a la derecha
        public void TextoDerecho(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agregamos espacios  para alinear a la derecha.
                }
                //Agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual,texto.Length - caracterActual));
            }
            else
            {
                //Variable para poner espacios restantes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agregamos espacios  para alinear a la derecha.
                }
                //Si no es mayor solo agregarlo
                linea.AppendLine(espacios + texto);
            }
        }

        //Metodo para centrar el texto
        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";

                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }
                //Agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCar - texto.Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += "";
                }

                linea.AppendLine(espacios + texto);
            }
        }

        //Metodo para poner texto a los extremos
        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            {
                textoIzq = textoIzquierdo;
            }

            textoCompleto = textoIzq;//Agregamos el primer texto.

            if (textoDerecho.Length > 20)//si es mayor a 20 lo cortamos
            {
                cortar   = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }else
            {
                textoDer = textoDerecho;
            }
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i  = 0; i  < nroEspacios; i ++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            linea.AppendLine(textoCompleto);//Agregamos la linea al ticket, al objeto en si.
        }

        //Metodo para agregar los totales de la venta
        public void AgregarTotales(string texto, decimal total)
        {
            //Variables  que usaremos
            string resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }else
            {
                resumen = texto;
            }

            textoCompleto = resumen;
            valor = total.ToString("#,#.00");
            //Obtenemos el numero de espacios restantes para alinearlos a la derecha
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            //Agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += "";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }
        public void AgregarArticulo(string articulo, int cant, decimal precio, decimal importe)
        {
            //Valida la cantidad
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false;
                int nroEspacios = 0;

                //Si el nombre descripcion del articulo es mayor a  20, baja a la siguiente linea.
                if (articulo.Length > 20)
                {
                    //Colocar la cantidad a la derecha
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    //Colocar el precio a la derecha
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();
                    int caracterActual = 0;
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true;
                        }
                        else
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                            caracterActual += 20;
                        }
                        linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));
                    }

                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;

                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + importe.ToString();
                    linea.AppendLine(elemento);
                  }
                }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportadas por este");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportadas por este.");
            }
        }

        //Metodos para enviar secuencias de escape a la impresora

        public void CortarTicket()
        {
            linea.AppendLine("\x1B" + "m");
            linea.AppendLine("\x1B" + "d" + "\x09");
        }

        public void AbreCajon()
        {
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");
        }

        //public void ImprimirTicket(string impresora)
        //{
        //    RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
        //    linea.Clear();
        //}
    }
}
