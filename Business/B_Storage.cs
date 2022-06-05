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
		public static List<StorageEntity> StorageList()
		{
			using (var db = new InventoryContext())
			{
				return db.Storages.ToList();
			}
		}
		//crear y guardar info en db
		public static void CreateStorage(StorageEntity oStorage)
		{
			using (var db = new InventoryContext())
			{
				db.Storages.Add(oStorage);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
		
		//Encuentra si un producto existe en el almacenamiento
		public static bool IsProductInWarehouse(string idStorage)
        {
			using (var db = new InventoryContext())
            {
				var product = db.Storages.ToList().Where(p => p.StorageId == idStorage);
				return product.Any();	//Any, si existe un producto que cumpla con la consulta, retorna dato bool
            }
        }

		//actualizar info en db
		public static void UpdateStorage(StorageEntity oStorage)
		{
			using (var db = new InventoryContext())
			{
				db.Storages.Update(oStorage);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
