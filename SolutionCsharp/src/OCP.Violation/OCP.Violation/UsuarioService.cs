using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Violation
{
    internal class UsuarioService
    {
        public void CriarUsuario(Usuario usuario)
        {
            if (usuario.Tipo == TipoUsuarioEnum.Premium)
            {
                EnviarEmail(usuario);
                EnviarWhatsapp(usuario);
            }
            else if (usuario.Tipo == TipoUsuarioEnum.Basico)
            {
                EnviarEmail(usuario);
            }
            else if (usuario.Tipo == TipoUsuarioEnum.Convidado)
            {
                EnviarSms(usuario);
            }
        }

        private void EnviarEmail(Usuario usuario)
        {
            Console.WriteLine($"Email enviado para {usuario.Email}");
        }

        private void EnviarSms(Usuario usuario)
        {
            Console.WriteLine($"SMS enviado para {usuario.Nome}");
        }

        private void EnviarWhatsapp(Usuario usuario)
        {
            Console.WriteLine($"WhatsApp enviado para {usuario.Nome}");
        }
    }
}
