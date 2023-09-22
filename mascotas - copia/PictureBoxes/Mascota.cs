using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureBoxes
{

	public class Mascota {

	//Atributos
	private readonly String id;
	private String duenio;
	private String raza;
	private int rapidez;
	private Bitmap foto;

	//Constructores
	public Mascota()
	{
		this.id = "";
		this.duenio = "";
		this.raza = "";
		this.rapidez = 0;
	}

	public Mascota(String vid, String vduenio, String vraza, int vrapidez, Bitmap vfoto)
	{
		this.id = vid;
		this.duenio = vduenio;
		this.raza = vraza;
		this.rapidez = vrapidez;
			this.foto = vfoto;
	}

	//Propiedades
	public String getId()
	{
		return this.id;
	}

	public String getDuenio()
	{
		return this.duenio;
	}

		public Bitmap getFoto()
		{
			return this.foto;
		}

		
		public String getRaza()
	{
		return this.raza;
	}

	public int getRapidez()
	{
		return this.rapidez;
	}

	public void setDuenio(String vDuenio)
	{
		this.duenio = vDuenio;
	}

	public void setRaza(String vRaza)
	{
		this.raza = vRaza;
	}

	public void setRapidez(int vRapidez)
	{
		this.rapidez = vRapidez;
	}

	//Metodos Object
	public override String ToString()
	{
		String space = " ";
		return "nombre mascota : "+this.id + " " + space + " nombre duenio: " + this.duenio + " " + this.raza + " rapidez:  " + this.rapidez + "\n";
	}

	public override  Boolean Equals(Object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		if (!(obj is Mascota)) {
			return false;
		}
		Mascota otro = (Mascota)obj;
		if (id != otro.id)
		{
			return false;
		}
		return true;
	}

	

}

}
