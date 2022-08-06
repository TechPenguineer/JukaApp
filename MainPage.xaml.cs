using JukaCompiler;
namespace JukaApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        RunJukaBtn.Text = $"Running Code...";
		
		SemanticScreenReader.Announce(RunJukaBtn.Text);
        //outputText.Text
		String data = new Compiler().Go(codeeditor.Text, isFile: false);
		Webhook.UFWS webManager = new JukaApp.Webhook.UFWS();
		//webManager.SendWebhook(data,);
		outputText.Text = data;
        RunJukaBtn.Text = $"Run Juka";

    }

	private void codeeditor_TextChanged(object sender, TextChangedEventArgs e)
	{
        var oldText = e.OldTextValue;
        var newText = e.NewTextValue;
    }
}

