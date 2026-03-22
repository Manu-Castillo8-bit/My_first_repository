    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.OleDb;
    using System.Windows.Forms;

    namespace Películas
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
            //Variables principales
            System.Data.OleDb.OleDbConnection conBD = new
                System.Data.OleDb.OleDbConnection();
            String sAccion = "";

            public void abrirConexion()
            {
                //Se crea el string de conexión a la base de datos
                conBD.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\User\Desktop\Práctica 3\Películas.accdb; Persist Security Info=False";
                try
                {
                    //Se abre la base de datos
                    conBD.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión y una prueba  de vs code en chromebook" + ex);
                }
            }

            public void cerrarConexion()
            {
                //Se chequea si está la conexión abierta.
                if (conBD.State == ConnectionState.Open)
                {
                    //Se cierra la conexión
                    conBD.Close();
                }

            }
            private void desactivarAcciones()
            { butConsulta.Enabled = false;
                butAlta.Enabled = false;
                butBaja.Enabled = false;
                butModificacion.Enabled = false;
                butAceptar.Enabled = true;
                butCancelar.Enabled = true;
            }

            private void activarAcciones()
            {
                butConsulta.Enabled = true;
                butAlta.Enabled = true;
                butBaja.Enabled = true;
                butModificacion.Enabled = true;
                butAceptar.Enabled = false;
                butCancelar.Enabled = false;
                //Se cancela la acción a realizar
                sAccion = "";
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                //Se abre la conexión a la base de datos
                abrirConexion();
            }

            private void butSalir_Click(object sender, EventArgs e)
            {
                //Se cierra la conexión antes de terminar
                cerrarConexion();
                //Se finaliza el programa
                this.Close();
            }

            private void butConsulta_Click(object sender, EventArgs e)
            {
                //Se indica la acción que hay que realizar
                sAccion = "Consulta";
                //Se activan y desactivan los botones correspondientes.
                desactivarAcciones();
            }

            private void butAlta_Click(object sender, EventArgs e)
            {
                //Se indica la acción que hay que realizar
                sAccion = "Alta";
                //Se activan y desactivan los botones correspondientes.
                desactivarAcciones();
            }

            private void butBaja_Click(object sender, EventArgs e)
            {
                //Se indica la acción que hay que realizar
                sAccion = "Baja";
                //Se activan y desactivan los botones correspondientes.
                desactivarAcciones();
            }

            private void butModificacion_Click(object sender, EventArgs e)
            {
                //Se indica la acción que hay que realizar
                sAccion = "Modificacion";
                //Se activan y desactivan los botones correspondientes.
                desactivarAcciones();
            }

            private void butCancelar_Click(object sender, EventArgs e)
            {
                //Se activan y desactivan los botones correspondientes.
                activarAcciones();
            }

            private void butAceptar_Click(object sender, EventArgs e)
            {
                //Se chequea la acción que hay que ejecutar
                if (sAccion == "Consulta")
                {
                    //Se chequea si hay algún código metido
                    try
                    {
                        if (Convert.ToInt32(txtCodigo.Text) > 0)
                        {
                            //Se realiza la consulta
                            string sConsulta = "SELECT * FROM Peliculas WHERE Código = " + txtCodigo.Text;

                            //Se ejecuta el comando y se lee el resultado para ver si hay alguno
                            using (OleDbCommand oleComando = new OleDbCommand(sConsulta, conBD))
                            using (OleDbDataReader oleReader = oleComando.ExecuteReader())
                            {
                                if (oleReader.Read())
                                {
                                    //Se modifican las cajas de texto con los datos del registro leido
                                    txtTitulo.Text = Convert.ToString(oleReader["Título"]);
                                    txtMinutos.Text = Convert.ToString(oleReader["Duración"]);
                                }
                                else
                                {
                                    //Si no hay ningún registro, se indica con un mensaje
                                    MessageBox.Show("El código introducido no existe");
                                }
                            }
                        }
                        else
                        {
                            //Si se ha metido un código negativo, se solicita otro.
                            MessageBox.Show("Introducir un código válido antes de consultar");
                        }
                    }
                    catch (Exception ex)
                    { //Si se ha introducido un código no numérico, se solicita otro.
                        MessageBox.Show("Introducir un código antes de consultar");
                    }
                }
                else
                {
                    if (sAccion == "Alta")
                    { try
                        {
                            //Se realiza la inserción 
                            String sConsulta = "INSERT INTO Peliculas (Título, Duración) VALUES ('" + txtTitulo.Text + "', " + txtMinutos.Text + ")";
                            OleDbCommand oleComando = new OleDbCommand();
                            oleComando.CommandType = CommandType.Text;
                            oleComando.CommandText = sConsulta;
                            oleComando.Connection = conBD;

                            //Se ejecuta el comando de inserción
                            oleComando.ExecuteNonQuery();

                            //Se borran las cajas de texto
                            txtCodigo.Text = "";
                            txtTitulo.Text = "";
                            txtMinutos.Text = "";
                        } catch (Exception ex)
                        {
                            //Si se ha producido un error en el código, se muestra un mensaje.
                            MessageBox.Show("Error en la inserción");
                        }
                    } else {
                        if (sAccion == "Baja")
                        {
                            try
                            {
                                //Se realiza la eliminación
                                String sConsulta = "DELETE FROM Peliculas WHERE Código=" + txtCodigo.Text;
                                OleDbCommand oleComando = new OleDbCommand();
                                oleComando.CommandType = CommandType.Text;
                                oleComando.CommandText = sConsulta;
                                oleComando.Connection = conBD;
                                //Se ejecuta el comando de eliminación
                                oleComando.ExecuteNonQuery();
                                //Se borran las cajas de texto
                                txtCodigo.Text = "";
                                txtTitulo.Text = "";
                                txtMinutos.Text = "";

                            }
                            catch (Exception ex)
                            {
                                //Si se ha producido un error, se muestra un mensaje.
                                MessageBox.Show("Error en el borrado");
                            }
                        }
                        else
                        {
                            try
                            {
                                //Se realiza la modificación
                                String sConsulta = "UPDATE Peliculas SET Título='" + txtTitulo.Text + "', Duración=" + txtMinutos.Text + " WHERE Código=" + txtCodigo.Text;
                                OleDbCommand oleComando = new OleDbCommand();
                                oleComando.CommandType = CommandType.Text;
                                oleComando.CommandText = sConsulta;
                                oleComando.Connection = conBD;
                                //Se ejecuta el comando de modificación

                                oleComando.ExecuteNonQuery();
                                //Se borran las cajas de texto
                                txtCodigo.Text = "";
                                txtTitulo.Text = "";
                                txtMinutos.Text = "";
                            }
                            catch (Exception ex)
                            {
                                //Si se ha producido un error, se muestra un mensaje.
                                MessageBox.Show("Error al modificar");
                            }
                        }
                    }
                }
                //Se termina la acción realizada
                sAccion = "";
                //Se activan y desactivan los botones correspondientes.
                activarAcciones();

                //En resumen, el programa se conecta a una base de datos Access,
                //y permite realizar consultas, altas, bajas y modificaciones
                //sobre una tabla de películas. El usuario puede introducir un código
                //para consultar o modificar un registro específico, o dejarlo en blanco
                //para insertar un nuevo registro. El programa maneja errores comunes como
                //códigos no numéricos o acciones no válidas, mostrando mensajes informativos al usuario.

                //_____________________________________________________________________________________________________

                //A continuación los comandos más importantes y para que funcionan:

                /* 
                - OleDbConnection: Es la clase que se utiliza para establecer una conexión
                con una base de datos Access.

                - OleDbCommand: Es la clase que se utiliza para ejecutar comandos SQL contra
                la base de datos.

                - ExecuteReader(): Es un método de OleDbCommand que se utiliza para ejecutar
                una consulta SQL que devuelve un conjunto de resultados (como SELECT). 
                Devuelve un OleDbDataReader que se puede usar para leer los datos.

                - ExecuteNonQuery(): Es un método de OleDbCommand que se utiliza para ejecutar 
                comandos SQL que no devuelven resultados (como INSERT, UPDATE, DELETE). 
                Devuelve el número de filas afectadas por el comando.

                - MessageBox.Show(): Es un método que se utiliza para mostrar un cuadro 
                de diálogo con un mensaje al usuario. Es útil para informar sobre
                errores o resultados de acciones.*/


        }
    }
}


