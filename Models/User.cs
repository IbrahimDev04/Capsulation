namespace ConsoleApp17.Models
{
    internal class User
    {
        string _name = "YYY";
        string _surname = "XXX";
        string _username;
        string _password;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (CheckLetter(value.Trim()) && value.Length > 3 && value.Length < 25)
                {
                    _name = Capitalize(value);
                }
                else
                {
                    Console.WriteLine("Yanlis yazilib");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                if (CheckLetter(value.Trim()) && value.Length > 3 && value.Length < 25)
                {
                    _surname = Capitalize(value);
                }
                else
                {
                    Console.WriteLine("Yanlis yazilib");
                }
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            set
            {
                if (CheckLower(value) && CheckDigit(value) && CheckUpper(value) & value.Length>=8)
                {
                    _password = value;
                    Console.WriteLine("ugurla yaradildi");
                }
                else
                {
                    Console.WriteLine("Dogru formatda password gir");
                }
            }
        }

        public User(string name, string surname, string password)
        {
            Name = name;
            Surname = surname;
            Password = password;
            _username = String.Concat(Name.Substring(0,3),".",Surname.Substring(0,3));

        }

        private bool CheckLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private string Capitalize(string name)
        {
            name = name.Trim();
            name = String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
            return name;
        }

        private bool CheckLower(string password)
        {
            for (int i = 0; i < password.Length;i++)
            {
                if (Char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            if (oldPass == _password)
            {
                Password = newPass;
                Console.WriteLine("Parolunuz ugurla deyisildi.");
            }
            else
            {
                Console.WriteLine("Parolunuzu duzgun girin.");
            }
        }

    }
}
