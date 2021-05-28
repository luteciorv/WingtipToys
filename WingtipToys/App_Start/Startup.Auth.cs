using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.Google;
using Owin;
using WingtipToys.Models;

namespace WingtipToys
{
    public partial class Startup {

        // Para obter mais informações sobre autenticação de configuração, visite https://go.microsoft.com/fwlink/?LinkId=301883
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configurar contexto db, gerenciador de usuários e gerenciador de entradas para usar uma única instância por solicitação
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Ativar o aplicativo para usar um cookie e armazenar informações para o usuário conectado
            // e usar um cookie para armazenar temporariamente informações sobre um logon de usuário com um provedor de logon terceirizado
            // Configure o cookie de entrada
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
            // Use um cookie para armazenar temporariamente informações sobre um logon de usuário com um provedor de logon terceirizado
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Permite que o aplicativo armazene temporariamente informações dos usuários quando eles estiverem verificando o segundo fator no processo de autenticação de dois fatores.
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // Permite que o aplicativo lembre o segundo fator de verificação de logon, como um telefone ou email.
            // Depois de marcar esta opção, sua segunda etapa de verificação durante o processo de logon será lembrada no dispositivo do qual você entrou.
            // Isso é semelhante à opção RememberMe quando você entra.
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);

            // Remover comentário das linhas a seguir para ativar o logon com provedores de logon terceirizados
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //app.UseFacebookAuthentication(
            //   appId: "",
            //   appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
        }
    }
}
