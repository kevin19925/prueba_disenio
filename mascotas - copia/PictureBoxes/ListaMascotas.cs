using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PictureBoxes
{
	
	public class ListaMascotas
	{

		//Atributos
		private ArrayList ListA;

		//Constructores
		public ListaMascotas()
		{
			ListA = new ArrayList();
		}
		public void setListaMascota(ArrayList a)
		{
			ListA = a;
		}

		//Propiedades
		public ArrayList getListA()
		{
			return ListA;
		}

		

		//Metodos de objeto
		public void AgregarMascota(Mascota a)
		{
			ListA.Add(a);
		}


		public Mascota BuscarMascota(String vid)
		{
			foreach(Mascota a in ListA)
			{
				if (vid.Equals(a.getId()))
				{
					return a;
				}
			}
			return null;
		}

		public void eliminar(String vid)
		{
			foreach (Mascota a in ListA)
			{
				if (true == vid.Equals(a.getId()))
				{
					ListA.Remove(a);
				}
			}
		}


		public ArrayList mostrarduenios(String vduenio)
		{
			ArrayList m  = new ArrayList();
			foreach (Mascota a in  ListA)
			{
				if (vduenio.Equals(a.getDuenio()))
				{
					m.Add(a);
				}
			}
			return m;
		}

		public ArrayList mostrarRazas(String vRazas)
		{
			ArrayList m = new ArrayList();
			foreach (Mascota a in ListA)
			{
				if (vRazas.Equals(a.getRaza()))
				{
					m.Add(a);
				}
			}
			return m;
		}

		public ArrayList mostrarlento(int vrazpidez)
		{
			ArrayList m = new ArrayList();
			foreach (Mascota a in ListA)
			{
				if (a.getRapidez() < vrazpidez)
				{
					m.Add(a);
				}
			}
			return m;
		}

		public ArrayList mayorRapidez(int vrapidez)
		{
			ArrayList m = new ArrayList();
			foreach (Mascota a in ListA)
			{
				if (a.getRapidez() > vrapidez)
				{
					m.Add(a);
				}
			}
			return m;
		}

		/*public Automovil autoanterior(String vMatricula) {
			it  = ListA.listIterator();
			Automovil a, b, retorno = null;
			while (it.hasNext()) {
				a = it.next();
				b = it.previous();
				if(a.getMatricula().equals(vMatricula)) {
						if(a.getKms() > b.getKms()) {
							retorno = a;
							break;
						}else {
							retorno = b;
							break;
						}

					}else {
						retorno = new Automovil();
						break;
					}
				}
			return retorno;
			}*/

		

	}


}
