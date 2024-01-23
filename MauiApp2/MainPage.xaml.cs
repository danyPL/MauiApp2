
namespace MauiApp2
{
  
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
    
        public void AddUser(object sender, EventArgs e)
        {
            string mail = email.Text;
            string password1 = pass1.Text;
            string password2 = pass2.Text;
            if(mail.Contains("@"))
            {
                if(password1 == password2)
                {
                    List<User> users = new List<User>();
                    string path = Path.Combine(FileSystem.Current.AppDataDirectory, "users.txt");
                    if(!File.Exists(path))
                    {
                        File.Create(path).Close();
                    
                    }
                    StreamWriter writter = new StreamWriter(path);
                    string user = $"{mail};{password1}";
                    User newuser = new User(mail, password2);
                    users.Add(newuser);
                    writter.WriteLine(user);

                    writter.Close();
                    StreamReader streamReader = new StreamReader(path);
                    string[] user2 = streamReader.ReadLine().Split(";");

                    
                    info.Text = $"Witaj {mail} {user2[0]}";
                    
                }
                else
                {
                    info.Text = "Hasła różnią się";
                }
            }
            else
            {
                info.Text = "Nieprawidłowy adres e-mail";
            }
        }
    }

}
