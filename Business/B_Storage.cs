using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
				var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);
				return product.Any();	//Any, si existe un producto que cumpla con la consulta, retorna dato bool
            }
        }

		public static List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
		{
			using (var db = new InventoryContext())
			{
				return db.Storages.Include(s => s.Product)
								  .Include(s => s.Warehouse)
								  .Where(s => s.WarehouseId == idWarehouse)
								  .ToList();
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
