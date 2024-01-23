namespace Roman;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void btnConvert_Clicked(System.Object sender, System.EventArgs e)
    {
        Int32 dblInput;
        bool isNumber;
        Converter converter = new Converter();

        isNumber = Int32.TryParse(txtInput.Text, out dblInput);

        if (isNumber)
        {
            lblDisplay.Text = converter.NumberToRoman(dblInput);
        }
        else
        {
            lblDisplay.Text = converter.RomanToNumber(txtInput.Text.ToUpper()).ToString();
        }
    }

    void btnClear_Clicked(System.Object sender, System.EventArgs e)
    {
        txtInput.Text = string.Empty;
        lblDisplay.Text = "0";
    }
}


