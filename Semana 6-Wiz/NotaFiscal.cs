using System;
using System.Drawing;

public class NotaFiscal
{
    public NotaFiscal()
    {
    }

    public String nomeCliente { get; set; }

    public  DateTime dataCompra { get; set; }

    public float total { get; set; }


    protected String Pedido
    {
        get
        {
            return nomeCliente + " " + dataCompra + " " + total;

        }
    }
        
    
}
