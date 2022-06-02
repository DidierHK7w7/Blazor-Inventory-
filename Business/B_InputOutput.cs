using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class B_InputOutput
	{
		public List<InputOutputEntity> OutputList()
		{
			using (var db = new InventoryContext())
			{
				return db.InOuts.ToList();
			}
		}
		//crear y guardar info en db
		public void CreateOutput(InputOutputEntity oOutput)
		{
			using (var db = new InventoryContext())
			{
				db.InOuts.Add(oOutput);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//actualizar info en db
		public void UpdateOutput(InputOutputEntity oOutput)
		{
			using (var db = new InventoryContext())
			{
				db.InOuts.Update(oOutput);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
