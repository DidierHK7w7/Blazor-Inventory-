using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class B_Storage
	{
		public List<StorageEntity> StorageList()
		{
			using (var db = new InventoryContext())
			{
				return db.Storages.ToList();
			}
		}
		//crear y guardar info en db
		public void CreateStorage(StorageEntity oStorage)
		{
			using (var db = new InventoryContext())
			{
				db.Storages.Add(oStorage);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//actualizar info en db
		public void UpdateStorage(StorageEntity oStorage)
		{
			using (var db = new InventoryContext())
			{
				db.Storages.Update(oStorage);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
