namespace Calculadora;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    

    private void Operaciones_Clicked(object sender, EventArgs e)
    {

        double valorUno;
        double valorDos;


        if(string.IsNullOrEmpty(primerValor.Text) || string.IsNullOrEmpty(segundoValor.Text))
        {
            error.Text = "Ingresa valores en todos los campos";
        }
        else
        {
            valorUno = Convert.ToInt16(primerValor.Text);
            valorDos = Convert.ToInt16(segundoValor.Text);


            error.Text = "";
            suma.Text = "Suma: " + Convert.ToString(Suma(valorUno, valorDos));
            resta.Text = "Resta: " +Convert.ToString(Resta(valorUno, valorDos));
            multiplicacion.Text = "Multiplicación: " + Convert.ToString(Multiplicacion(valorUno, valorDos));
        
            if(valorDos == 0)
            {
                division.Text = "División: " + "No se puede dividir entre cero";
            }
            else
            {
                division.Text = "División:" + Convert.ToString(Division(valorUno, valorDos));
            }

        }
        
        



    }
    private double Suma(double uno, double dos)
    {
        return uno + dos;
    }
    private double Resta(double uno, double dos)
    {
        return uno - dos;
    }
    private double Multiplicacion(double uno, double dos)
    {
        return uno * dos;
    }
    private double Division(double uno, double dos)
    {
        return uno / dos;

    }
}

