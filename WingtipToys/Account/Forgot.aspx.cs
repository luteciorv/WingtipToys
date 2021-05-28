using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WingtipToys.Models;

namespace WingtipToys.Account
{
    public partial class ForgotPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Forgot(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validar endereço de email do usuário
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                ApplicationUser user = manager.FindByName(Email.Text);
                if (user == null || !manager.IsEmailConfirmed(user.Id))
                {
                    FailureText.Text = "O usuário não existe ou não foi confirmado.";
                    ErrorMessage.Visible = true;
                    return;
                }
                // Para obter mais informações sobre como habilitar a confirmação da conta e redefinição de senha, visite https://go.microsoft.com/fwlink/?LinkID=320771
                // Envie um e-mail com o código e o redirecionamento para redefinir a página de senha
                //string code = manager.GeneratePasswordResetToken(user.Id);
                //string callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code, Request);
                //manager.SendEmail(user.Id, "Redefinir senha", "Redefina sua senha, clicando <a href=\"" + callbackUrl + "\">aqui</a>.");
                loginForm.Visible = false;
                DisplayEmail.Visible = true;
            }
        }
    }
}