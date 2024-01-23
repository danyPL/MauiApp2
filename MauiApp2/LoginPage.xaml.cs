namespace MauiApp2;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	public void Login(object sender,  EventArgs e)
	{
        List<User> users = new List<User>();
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, "users.txt");

        StreamReader file = new StreamReader(path);
        while (!file.EndOfStream)
        {
            string mail = email.Text;
            string pass = password.Text;

            string lines = file.ReadLine();
            if (lines.Split(";")[0] == mail && lines.Split(";")[1] == pass)
            {
                info.Text = "Zalogowano";
                file.Close();
            }

            }
           

        }
    }
