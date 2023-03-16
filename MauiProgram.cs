using Microsoft.Extensions.Logging;
using TestesFront.Models;

namespace TestesFront;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
			//criação da tabela
            DataBase.CreateDataBase(Path.Combine(FileSystem.AppDataDirectory, "user.db"));
			DataBase.Conexao.CreateTable(typeof(Login));
       
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
