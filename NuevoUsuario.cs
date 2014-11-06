using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Descripción breve de NuevoUsuario
/// </summary>
public class NuevoUsuario
{
     private string usuario;
     private string contrasena;

    public string Usuario
    {
        set 
        {
            if ( string.IsNullOrEmpty( value ) )
                usuario = value;
            else{ }
        }
		get 
        {
            return usuario;
        }
	}

    public string Contrasena
    {
        set
        {
            if ( string.IsNullOrEmpty(value) )
                contrasena = value;
            else { }
        }
        get
        {
            return contrasena;
        }
    }

    

	public NuevoUsuario(String user, String pass)
	{
        usuario = user;
        contrasena = pass;
	}
}
