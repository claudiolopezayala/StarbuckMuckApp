namespace TDMPW_411_2P_EX;

public partial class Cart : ContentPage
{

    Producto[] productos = new Producto[3];
    Producto productoSelecionado;

    public Cart()
    {
        InitializeComponent();
        productos[0] = new Frapuccino();
        productos[1] = new Rosquilla();
        productos[2] = new Te();

        productoSelecionado = productos[0];
        showProductoSeleccionado();
        this.stpCantidad.Value = 1;
        this.stpCantidad.Minimum = 1;
    }

    private void showProductoSeleccionado()
    {
        this.stpCantidad.Value = 1;
        this.imgProductoSeleccionado.Source = productoSelecionado.getImagen();
        this.lblProductoSeleccionado.Text = productoSelecionado.getNombreCompleto();
        this.lblTotal.Text = string.Format("{0:C}", productoSelecionado.getPrecio());
        changeTotal();
    }

    private void stpCantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int valor = (int) this.stpCantidad.Value;
        this.lblCantidad.Text = $"x{valor}";
        changeTotal();

    }

    private void changeTotal()
    {
        double valorUnitario = productoSelecionado.getPrecio();
        double cantidad = this.stpCantidad.Value;
        double total = valorUnitario * cantidad;
        this.lblTotalFinal.Text = string.Format("Total............{0:C}", total);
    }

    private void frapuccino_Tapped(object sender, EventArgs e)
    {
        productoSelecionado = productos[0];
        showProductoSeleccionado();
    }


    private void rosquilla_Tapped(object sender, EventArgs e)
    {
        productoSelecionado = productos[1];
        showProductoSeleccionado();
    }

    private void te_Tapped(object sender, EventArgs e)
    {
        productoSelecionado = productos[2];
        showProductoSeleccionado();
    }
}