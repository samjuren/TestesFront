using TestesFront.Models;

namespace TestesFront;

public partial class MainPage : ContentPage
{
    public DataBase contexto;

    public MainPage()
    {
        InitializeComponent();
        contexto = new DataBase();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Login login = new Login()
        {
            Nome = txt_Nome.Text,
            Senha = txt_Senha.Text
        };
        contexto.Inserir(login);
    }
}

