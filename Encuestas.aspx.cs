using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Encuestas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //Encabezados
        TableRow encabezado = new TableRow();
        TablaEncuestas.Rows.Add(encabezado);

        TableCell colEncuestas = new TableCell();
        colEncuestas.Text = "Seleccione una encuesta";
        encabezado.Cells.Add(colEncuestas);

        TableCell colSeleccion = new TableCell();
        DropDownList listado = new DropDownList();
        listado.ID = "lbEncuestas";
        listado.Items.Add("Seleccione una encuenta");


        EncuestaContext encuestas = new EncuestaContext("Data Source=VERONICA-PC\\sqlexpress;Initial Catalog=master;User ID=sa;Password=Atomico00");
        List<TipoEncuesta> total = new List<TipoEncuesta>();

        total = encuestas.ObtenerTiposDeEncuesta();

        foreach (TipoEncuesta x in total)
        {
            listado.Items.Add(new ListItem(x.Nombre,Convert.ToString(x.Id)));
        }
        colSeleccion.Controls.Add(listado);
        encabezado.Cells.Add(colSeleccion);
    }


}
