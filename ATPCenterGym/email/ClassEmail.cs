using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ATPCenter.tiposdeclase;
using System.Net;

namespace ATPCenterGym.email
{
    class ClassEmail
    {
        string _destino = "";
        string _asunto = "";
        string _body = "";

        public bool PagoCuota(string _d, string punto, string fechapago, string alumno, string tipoclase, string nombreclas, string vcuota, string numcuota, string vdebepagar, string vpagado, string vsaldo, string fechaproxvence)
        {
            _destino = _d;

            _asunto = "Notificación de Pago de Cuota - ATP Center";

            _body = " <html>";
            _body += "<body>";
            _body += "<table>";

            _body += "<tr>";
            _body += "<td colspan=2>ATP Center</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Local:</td><td> " + punto + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Fecha pago:</td><td>" + fechapago + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Nombre alumno:</td><td> " + alumno + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Tipo de clase:</td><td> " + tipoclase + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Tipo de clase:</td><td> " + nombreclas + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Valor cuota $:</td><td> " + vcuota + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Cuota N:</td><td>" + numcuota + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Monto a pagar $:</td><td> " + vdebepagar + "</td>";
            _body += "</tr>";


            _body += "<tr>";
            _body += "<td>Monto pagado $:</td><td> " + vpagado + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Saldo $:</td><td> " + vsaldo + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td>Próximo vencimiento:</td><td>" + fechaproxvence + "</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td colspan=2>se notifica el pago de cuota.</td>";
            _body += "</tr>";

            _body += "<tr>";
            _body += "<td colspan=2>Comprobante no valido como factura</td>";
            _body += "</tr>";

            _body += "</table>";
            _body += "</body>";
            _body += "</html>";

            return this.EnviarMail();
        }

        private bool EnviarMail()
        {
            try
            {
                var fromAddress = new MailAddress("serviciosmensajerias@gmail.com");
                var fromPassword = "123456a$";
                var toAddress = new MailAddress(this._destino);

                string subject = this._asunto;
                string body = this._body;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })


                    smtp.Send(message);

                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}