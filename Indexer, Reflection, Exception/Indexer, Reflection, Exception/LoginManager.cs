using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer__Reflection__Exception
{
    public class LoginManager
    {
        private List<User> users = new List<User>();

        public LoginManager()
        {
            // Test üçün bir neçə istifadəçi əlavə edək
            users.Add(new User("alex", "12345"));
            users.Add(new User("admin", "admin123"));
        }

        public void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new LoginException("İstifadəçi adı boş ola bilməz!");

            if (string.IsNullOrWhiteSpace(password))
                throw new LoginException("Şifrə boş ola bilməz!");

            User found = users.Find(u => u.Username == username);

            if (found == null)
                throw new LoginException("Bu adda istifadəçi mövcud deyil!");

            if (found.Password != password)
                throw new LoginException("Şifrə yanlışdır!");

            Console.WriteLine("Uğurla daxil oldunuz!");
        }
    }
}
