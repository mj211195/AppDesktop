using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormSuport : Form
    {
        //Constantes
       private const string emailSpace = "space.experience.game@gmail.com";
       private const byte   MAX_CAR_NOM = 40,
                            MIN_CAR_NOM = 3,
                            MAX_CAR_EMAIL = 50,
                            MIN_CAR_EMAIL = 5,
                            MAX_CAR_ASUN = 45,
                            MIN_CAR_ASUN = 5,
                            MIN_CAR_MSJ = 10;
        private const int   MAX_CAR_MSJ = 1000;


        public FormSuport()
        {
            InitializeComponent();
        }

        private void button_WOCEnviar_Click(object sender, EventArgs e)
        {
            ///TODO
            ///PROBLEM CON EL TRIM, NO SE ELIMINAN LOS ESPACIOS COMO DEBERÍA. POR CORREGIR.            
            ///MODIFICAR LA IMAGEN QUE SALTA CUANDO HAY CAMPOS ERRÓNEOS. ESCALARLA MEJOR.




            //Asignamos el valor de los textbox a unas variables para trabajar más cómodamente
            //con ellos
            String  nombre = textBoxNom.Text,
                    email = textBoxCorreo.Text,
                    emailVerif = textBoxCorreoVerificado.Text,
                    asunto = textBoxAsunto.Text,
                    mensaje = textBoxMensaje.Text;

            //String msjError = "No s'ha pogut enviar correctament el missatge: ";
            int numCamposCorrectos = 0;

            //Nombre
            nombre.TrimStart(' ');
            nombre.TrimEnd(' ');
            if (comprobarCampoSimple(nombre, "nombre"))
            {
                pictureBoxErrorNombre.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxErrorNombre.Visible = true;
               // msjError += "\n  - S'ha d'escriure un nom vàlid";
            }
            
            //Emails
            if (comprobarEmail(email))
            {
                pictureBoxErrorEmail.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxErrorEmail.Visible = true;
               // msjError += "\n  - S'ha d'escriure un email vàlid";
            }

            if (email.Equals(emailVerif))
            {
                pictureBoxErrorEmailValid.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxErrorEmailValid.Visible = true;
               // msjError += "\n  - El correu ha de ser el mateix en ambdós camps";
            }

            //Asunto
            asunto.TrimStart(' ');
            asunto.TrimEnd(' ');
            if (comprobarCampoSimple(asunto, "asunto"))
            {
                pictureBoxErrorAsunto.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxErrorAsunto.Visible = true;
              //  msjError += "\n  - S'ha d'escriure un assumpte vàlid";
            }

            //Mensaje
            mensaje.TrimStart(' ');
            mensaje.TrimEnd(' ');
            if (comprobarCampoSimple(mensaje, "mensaje"))
            {
                pictureBoxErrorMensaje.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxErrorMensaje.Visible = true;
              //  msjError += "\n  - S'ha d'escriure un missatge vàlid";
            }



            if (numCamposCorrectos == 5)
            {
                try
                {
                    /* Para poder enviar correos se tiene que activar una opción desde la cuenta
                     * de Google del remitente (en nuestro caso space.experience.game@gmail.com)
                     * (que ya está hecho)
                     * Enlace directo: https://myaccount.google.com/lesssecureapps?pli=1
                     */

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(emailSpace);
                    mail.To.Add(emailSpace);
                    mail.Subject = asunto;
                    //mail.Body = "This is for testing SMTP mail from GMAIL";
                    mail.Body = "----------------------------------------" +
                                "\nDatos de contacto: " +
                                "\n  Nombre: " + nombre +
                                "\n  Email: " + email +
                                "\n----------------------------------------" +
                                "\n\n" + mensaje +
                                "\n\n\n" + 
                                "**Mensaje enviado desde la app de escritorio**";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(emailSpace, "spaceGame1.");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Missatge enviat!" + 
                                    "\nL'hi respondrem al correu que ens ha facilitat en la màxima brevetat possible. " + 
                                    "\n\nGràcies,"+
                                    "\nSpace Experience Team", "Missatge enviat",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hi ha hagut algún problema a l'hora d'enviar el missatge." +
                                    "\nSi us plau, posi's en contacte amb nosaltres a través del nostre email:" +
                                    "\n\nspace.experience.game@gmail.com" +
                                    "\n\nMoltes gràcies.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
               // MessageBox.Show(msjError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            



            /*
            //Se intenta abrir el Outlook, el 'body' del mail será el texto del textBoxContacto
            try
            {
                String prueba = (String)richTextBoxContacto.Text;
                //Se tienen que reemplazar algunos carácteres para cargar correctamente Outlook
                prueba = prueba.Replace(" ", "%20");
                prueba = prueba.Replace("\n", "%0A");
                prueba = prueba.Replace(",", "%2C");

                String mensaje = "/c ipm.note /m space.experience.game@gmail.com&subject=Contacte%20Museu%20Terrassa&body=" + prueba;
                Process.Start("Outlook.exew", mensaje);
            }
            //En caso de que haya algún problema, mostrará error y más tarde cerrará el formulario
            catch
            {   
                DialogResult resultado =  MessageBox.Show("No s'ha pogut obrir correctament l'Outlook." +
                    "\n\nSi us plau, enviï'ns un correu expressant el seu problema/suggeriment al nostre correu: space.experience.game@gmail.com." +
                    "\nGràcies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (resultado == DialogResult.OK)
                {
                    Close();
                }
                
            }*/
        }

        private void button_WOCreiniciar_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = null;
            textBoxCorreo.Text = null;
            textBoxCorreoVerificado.Text = null;
            textBoxAsunto.Text = null;
            textBoxMensaje.Text = null;

            pictureBoxErrorNombre.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorEmailValid.Visible = false;
            pictureBoxErrorAsunto.Visible = false;
            pictureBoxErrorMensaje.Visible = false;

            textBoxNom.Focus();
        }

        /// <summary>
        /// Comprueba la cadena del textBoxEmail y retorna un booleano indicado si el campo es válido o no.
        /// Se pasa, por parámetro, la cadena.
        /// </summary>
        /// 
        /// <param name="email">El email (string) a comprobar</param>
        /// <returns>Devuelve true si es un campo correcto</returns>
        private bool comprobarEmail(String email)
        {
            //Damos por hecho que es válido puesto que todas las condiciones a las que someteremos al String
            //lo invalidan en caso de cumplir cualquiera de ellas
            bool correcto = true;

            int contadorArrobas = 0;
            foreach(char c in email)
            {
                if(c == '@')
                {
                    contadorArrobas++;
                }
            }


            if (email.Equals(null))
            {
                correcto = false;
            }
            else if (email.Length < MIN_CAR_EMAIL || email.Length > MAX_CAR_EMAIL)
            {
                correcto = false;
            }
            else if (String.IsNullOrWhiteSpace(email))
            {
                correcto = false;
            }
            else if(email.Contains(" "))
            {
                correcto = false;
            }
            else if (contadorArrobas == 0 || contadorArrobas > 1)
            {
                correcto = false;
            }

            return correcto;
        }

        /// <summary>
        /// Comprueba la cadena de algún textBox simple (cualquiera menos el email) y retorna un booleano indicado si el campo es válido o no.
        /// Se pasa, por parámetro, la cadena a verificar y otra cadena indicando qué campo es.
        /// </summary>
        /// 
        /// <param name="str">El string a comprobar</param>
        /// <param name="campo">Qué campo es</param>
        /// <returns>Devuelve true si es un campo correcto</returns>
        private bool comprobarCampoSimple(String str, String campo)
        {
            //Damos por hecho que es válido puesto que todas las condiciones a las que someteremos al String
            //lo invalidan en caso de cumplir cualquiera de ellas
            bool correcto = true;


            if (str.Equals(null))
            {
                correcto = false;
            }
            else if (String.IsNullOrWhiteSpace(str))
            {
                correcto = false;
            }

            //Comprobamos las correspondientes Length dependiendo de qué campo sea
            switch (campo)
            {
                case "nombre":
                    if (str.Length < MIN_CAR_NOM || str.Length > MAX_CAR_NOM)
                        correcto = false;
                    break;

                case "asunto":
                    if (str.Length < MIN_CAR_ASUN || str.Length > MAX_CAR_ASUN)
                        correcto = false;
                    break;

                default:
                    if (str.Length < MIN_CAR_MSJ || str.Length > MAX_CAR_MSJ)
                    correcto = false;
                    break;
            }

            return correcto;
        }
    }
}
